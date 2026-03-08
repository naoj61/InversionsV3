using Comuns;
using Controls;
using Inversions.ClassesEntity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Inversions.GUI
{
    public partial class EmpresesProductesTab : TabX
    {
        private InversionsBDContext vConnEmpreses;
        private InversionsBDContext vConnProductes;
        private Empresa vEmpresaSeleccionada;
        private Producte vProducteSeleccionat;

        public EmpresesProductesTab()
        {
            InitializeComponent();
        }

        #region *** Mètodes ***

        /// <summary>
        ///     Mostra o amaga els controls en funvio del tipus d'empresa seleccionada.
        /// </summary>
        private void preparaControlsProducte()
        {
            if (vEmpresaSeleccionada == null)
                return;

            if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses))
            {
                pnFons.Visible = false;
                pnAccions.Visible = false;
                grDescripcioProducte.Visible = false;

                ntbOrdreGridProducte.Focus();
            }
            else if (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.Accions)
            {
                pnFons.Visible = false;
                pnAccions.Visible = true;
                grDescripcioProducte.Visible = false;

                ntbOrdreGridProducte.Focus();
            }
            else if (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.GestoraFons)
            {
                pnFons.Visible = true;
                pnAccions.Visible = false;
                grDescripcioProducte.Visible = true;

                tbNomProducte.Focus();
            }
        }

        private void carregaGridProductes(Empresa empresa)
        {
            vConnProductes = new InversionsBDContext(); // Creo la connexió per si he fet cancel rellegeixi les dades de la taula.

            dgvProductes.RowEnter -= dgvProductes_RowEnter;

            if (empresa == null)
            {
                vConnProductes.Productes.Load();
                dgvProductes.DataSource = vConnProductes.Productes.Local.ToBindingList();
            }
            else
            {
                if (empresa.TipusEmpresa == TipusEmpresa.Accions)
                {
                    vConnProductes.ProdAccions.Where(w => w.EmpresaId == empresa.Id).Load();
                    dgvProductes.DataSource = vConnProductes.ProdAccions.Local.ToBindingList();
                }
                else if (empresa.TipusEmpresa == TipusEmpresa.GestoraFons)
                {
                    vConnProductes.ProdFons.Where(w => w.EmpresaId == empresa.Id).Load();
                    dgvProductes.DataSource = vConnProductes.ProdFons.Local.ToBindingList();
                }
            }
            dgvProductes.ClearSelection();
            dgvProductes.RowEnter += dgvProductes_RowEnter;

            if (((ICollection)dgvProductes.DataSource).Count == 0 || dgvProductes.SelectedRows.Count == 0)
            {
                tbNomProducte.Text = String.Empty;
                tbTickerExchangeFons.Text = String.Empty;
                tbTickerExchangeAccions.Text = String.Empty;
                ntbOrdreGridProducte.Valor = 0;
                cbMercatProducte.SelectedItem = null;
                cbMonedaProducte.SelectedItem = null;
                cbTipusProducte.SelectedItem = null;
                tbIsinProducte.Text = String.Empty;
                tbTickerAccio.Text = String.Empty;
                tbDescripcioProducte.Text = String.Empty;

                modeConsulta();

                preparaControlsProducte();
            }
            else
            {
                if (empresa == null)
                    btNouProducte.Enabled = false;
                else
                    btNouProducte.Enabled = empresa.TipusEmpresa == TipusEmpresa.GestoraFons;
            }
        }

        private void ompleCampsProducte(Producte producte)
        {
            if (vEmpresaSeleccionada == null)
                return;

            preparaControlsProducte();

            if (producte == null)
            {
                tbNomProducte.Text = String.Empty;
                tbTickerExchangeFons.Text = String.Empty;
                tbTickerExchangeAccions.Text = String.Empty;
                ntbOrdreGridProducte.Valor = 0;
                cbMercatProducte.SelectedItem = null;
                cbMonedaProducte.SelectedItem = null;
                cbTipusProducte.SelectedItem = null;
                tbIsinProducte.Text = String.Empty;
                tbTickerAccio.Text = String.Empty;
                tbDescripcioProducte.Text = String.Empty;
            }
            else
            {
                tbNomProducte.Text = producte._NomProducte;
                ntbOrdreGridProducte.Valor = producte.OrdreGrid.GetValueOrDefault();
                cbMonedaProducte.SelectedItem = producte.Moneda;

                if (producte is ProdAccions)
                {
                    tbTickerExchangeAccions.Text = producte.TickerExchange;
                    tbTickerAccio.Text = ((ProdAccions)producte).Ticker;
                    cbMercatProducte.SelectedItem = producte._Mercat;
                }
                else if (producte is ProdFons)
                {
                    tbTickerExchangeFons.Text = producte.TickerExchange;
                    tbIsinProducte.Text = producte._Isin;
                    tbDescripcioProducte.Text = producte._Descripcio;
                    cbTipusProducte.SelectedItem = ((ProdFons)producte).Tipus;
                }
            }
        }

        private void carregaGridEmpreses()
        {
            vConnEmpreses = new InversionsBDContext(); // Creo la connexió per si he fet cancel rellegeixi les dades de la taula.
            vConnEmpreses.Empreses.Load();

            var empreses = vConnEmpreses.Empreses.Local.ToList();

            if (!ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Accions))
                empreses = empreses.Where(w => w.TipusEmpresa != TipusEmpresa.Accions).ToList();
            if (!ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Fons))
                empreses = empreses.Where(w => w.TipusEmpresa != TipusEmpresa.GestoraFons).ToList();

            dgvEmpreses.DataSource = new BindingList<Empresa>(empreses);
        }

        private void teclaEscapeEdicioProducte()
        {
            var control = ActiveControl as IValorControlRestaurable;
            if (control != null)
            {
                if (control.Modified)
                    control.Undo();
            }
        }

        internal override void carregaInicial()
        {
            base.carregaInicial();

            dgvEmpreses.AutoGenerateColumns = false;
            dgvProductes.AutoGenerateColumns = false;

            carregaCombos();

            modeConsulta();
        }

        private void carregaCombos()
        {
            cbMercatProducte.SuspendLayout();
            cbMercatProducte.DisplayMember = "Nom";
            cbMercatProducte.DataSource = Mercat.Tuples.ToList();
            cbMercatProducte.SelectedItem = null;
            cbMercatProducte.ResumeLayout();

            cbMonedaProducte.SuspendLayout();
            cbMonedaProducte.DataSource = Moneda.Tuples.OrderBy(o => o.Ordre).ToList();
            cbMonedaProducte.DisplayMember = "Descripcio";
            cbMonedaProducte.ValueMember = "Codi";
            cbMonedaProducte.ResumeLayout();

            cbTipusProducte.SuspendLayout();
            cbTipusProducte.DataSource = Enum.GetValues(typeof(TipusFons));
            cbTipusProducte.SelectedItem = null;
            cbTipusProducte.ResumeLayout();
        }

        protected override void modeEdicio()
        {
            base.modeEdicio();

            btDesaProducte.Enabled = true;
            btCancelaProducte.Enabled = true;
            btNouProducte.Enabled = false;
            btEsborraProducte.Enabled = false;
            btEditaProducte.Enabled = false;
            grEmpresa.Enabled = false;
            dgvProductes.Enabled = false;
            cbMonedaProducte.Enabled = true;
            cbMercatProducte.Enabled = true;
            cbTipusProducte.Enabled = true;
            tbNomProducte.ReadOnly = false;
            ntbOrdreGridProducte.ReadOnly = false;
            tbIsinProducte.ReadOnly = false;
            tbTickerAccio.ReadOnly = false;
            tbDescripcioProducte.ReadOnly = false;
        }

        protected override void modeConsulta()
        {
            base.modeConsulta();

            btDesaProducte.Enabled = false;
            btCancelaProducte.Enabled = false;
            btNouProducte.Enabled =
                vEmpresaSeleccionada != null
                && (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.GestoraFons 
                || dgvProductes.RowCount == 0);
            btEsborraProducte.Enabled = vProducteSeleccionat != null;
            btEditaProducte.Enabled = vProducteSeleccionat != null;
            grEmpresa.Enabled = true;
            dgvProductes.Enabled = true;
            cbMonedaProducte.Enabled = false;
            cbMercatProducte.Enabled = false;
            cbTipusProducte.Enabled = false;
            tbNomProducte.ReadOnly = true;
            ntbOrdreGridProducte.ReadOnly = true;
            tbIsinProducte.ReadOnly = true;
            tbTickerAccio.ReadOnly = true;
            tbDescripcioProducte.ReadOnly = true;
        }

        internal override void escape(object sender, KeyEventArgs e)
        {
            base.escape(sender, e);

            teclaEscapeEdicioProducte();
        }

        internal override void refresca()
        {
            base.refresca();

            carregaCombos();

            if (dgvEmpreses.CurrentRow == null)
            {
                carregaGridEmpreses();
                return;
            }

            object currentEmpreses = dgvEmpreses.CurrentRow.DataBoundItem;
            object currentProductes = dgvProductes.CurrentRow != null ? dgvProductes.CurrentRow.DataBoundItem : null;

            carregaGridEmpreses();

            foreach (DataGridViewRow row in dgvEmpreses.Rows)
            {
                if (currentEmpreses.Equals(row.DataBoundItem))
                {
                    dgvEmpreses.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    break;
                }
            }

            if (dgvEmpreses.CurrentRow != null && currentEmpreses.Equals(dgvEmpreses.CurrentRow.DataBoundItem))
            {
                if (currentProductes == null)
                    return;

                foreach (DataGridViewRow row in dgvProductes.Rows)
                {
                    if (currentProductes.Equals(row.DataBoundItem))
                    {
                        dgvProductes.CurrentCell = row.Cells[0];
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        #endregion *** Mètodes ***

        #region *** Events ***

        private void btEditaProducte_Click(object sender, EventArgs e)
        {
            modeEdicio();
        }

        private void btNouProducte_Click(object sender, EventArgs e)
        {
            if (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.Accions)
            {
                vProducteSeleccionat = vConnProductes.ProdAccions.Create();
            }
            else if (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.GestoraFons)
            {
                vProducteSeleccionat = vConnProductes.ProdFons.Create();
            }
            else
            {
                vProducteSeleccionat = null;
            }

            if (vProducteSeleccionat != null)
            {
                vProducteSeleccionat.Empresa = vConnProductes.Empreses.Find(vEmpresaSeleccionada.Id);
                vProducteSeleccionat.MonedaCodi = Utilitats.Monedes.EUR.ToString();
                vProducteSeleccionat.OrdreGrid = 999;
            }

            ompleCampsProducte(vProducteSeleccionat);
            modeEdicio();
        }

        private async void btDesaProducte_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNomProducte.Text.Length > 50)
                    throw new Exception("El nom del producte no pot ser més llarg de 50 caracters");

                bool esProdNou = vProducteSeleccionat.Id == 0;

                vProducteSeleccionat.OrdreGrid = ntbOrdreGridProducte._IntValue;
                vProducteSeleccionat.MonedaCodi = cbMonedaProducte.SelectedItem.ToString();

                if (!ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses))
                {
                    if (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.Accions)
                    {
                        ((ProdAccions)vProducteSeleccionat).Mercat = vConnProductes.Mercats.Find(((Mercat)cbMercatProducte.SelectedItem).Id);
                        var nouTicker = tbTickerAccio.Text.ToUpper();
                        if (((ProdAccions)vProducteSeleccionat).Ticker != nouTicker)
                        {
                            ((ProdAccions)vProducteSeleccionat).Ticker = nouTicker;
                            if (String.IsNullOrEmpty(nouTicker))
                            {
                                vProducteSeleccionat.TickerExchange = null;
                            }
                            else
                            {
                                try
                                {
                                    var tickerExchange = await EodhdUserService.GetTicker(nouTicker);
                                    if (tickerExchange != null)
                                    {
                                        vProducteSeleccionat.TickerExchange = tickerExchange;
                                    }
                                }
                                catch (EodhdApiException ex)
                                {
                                    MessageBox.Show($"No s'ha pogut obtenir el ticker exchange de la acció. \nError: {ex.Message}"
                                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else if (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.GestoraFons)
                    {
                        ((ProdFons)vProducteSeleccionat).Nom = tbNomProducte.Text;
                        ((ProdFons)vProducteSeleccionat).ISIN = tbIsinProducte.Text.ToUpper();
                        ((ProdFons)vProducteSeleccionat).Tipus = ((TipusFons)cbTipusProducte.SelectedItem);
                        ((ProdFons)vProducteSeleccionat).Descripcio = tbDescripcioProducte.Text;
                    }
                }

                vConnProductes.Productes.AddOrUpdate(vProducteSeleccionat);

                vConnProductes.SaveChanges();

                Producte.RefrescaTaula();
                ProdAccions.RefrescaTaula();
                ProdFons.RefrescaTaula();

                ActivaRefrescaEnTabs(this);

                if (esProdNou)
                {
                    // Selecciona la nova fila.
                    dgvProductes.CurrentCell = dgvProductes.Rows[dgvProductes.Rows.GetLastRow(DataGridViewElementStates.Visible)].Cells[0];
                }

                modeConsulta();
            }
            catch (DbUpdateException ex3)
            {
                bool escriuLog = true;

                Exception inEx = ex3;

                while (inEx != null)
                {
                    if (inEx is SqlException)
                    {
                        var sqlEx = (SqlException)inEx;

                        if (sqlEx.Number == 2601 || sqlEx.Number == 2627)
                        {
                            // Esborra el producte creat amb errors.
                            vConnProductes.UndoingChangesDbEntityPropertyLevel(vProducteSeleccionat);

                            escriuLog = false;
                            MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        }
                    }

                    inEx = inEx.InnerException;
                }

                if (escriuLog)
                    Utilitats.EscriuLog(ex3);
            }
            catch (DbEntityValidationException ex)
            {
                string message = "\nValidation Errors: ";

                foreach (DbValidationError error in ex.EntityValidationErrors.SelectMany(entity => entity.ValidationErrors))
                {
                    message += String.Format("\nNom camp: {0}, Missatge: {1}", error.PropertyName, error.ErrorMessage);
                }

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Esborra el producte creat amb errors.
                vConnProductes.UndoingChangesDbEntityPropertyLevel(vProducteSeleccionat);


                //// Retrieve the error messages as a list of strings.
                //var errorMessages = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
                //var xx = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);

                //// Join the list to a single string.
                //var fullErrorMessage = string.Join("; ", errorMessages);

                //// Combine the original exception message with the new one.
                //var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                //// Throw a new DbEntityValidationException with the improved exception message.
                //throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);


                //if (ex.HResult == -2146232032)
                //{
                //    foreach (var validationErrors in ex.EntityValidationErrors)
                //    {
                //        foreach (var validationError in validationErrors.ValidationErrors)
                //        {
                //            var valorDuplicat = validationErrors.Entry.Entity;
                //            var missatge = validationError.ErrorMessage;
                //        }
                //    }
                //}
                //else
                //    Utilitats.EscriuLog(ex);
            }
            catch (Exception ex1)
            {
                Utilitats.EscriuLog(ex1, true);
            }
        }

        private void dgvEmpreses_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                DataGridViewCell cela = dgvEmpreses[e.ColumnIndex, e.RowIndex];
                var valorNou = (string)cela.EditedFormattedValue;
                if (cela.OwningRow.DataBoundItem != null)
                {
                    switch (cela.OwningColumn.DataPropertyName)
                    {
                        case "Nom":
                            if (String.IsNullOrWhiteSpace(valorNou))
                                throw new ApplicationException("El nom no pot ser buit o null");
                            break;

                        case "TipusEmpresa":
                            object valorInicial = cela.Value;
                            var tipusEmp = (TipusEmpresa)Enum.Parse(typeof(TipusEmpresa), valorNou);

                            if ((TipusEmpresa)valorInicial != tipusEmp)
                            {
                                var empresa = (Empresa)cela.OwningRow.DataBoundItem;
                                if (empresa.Productes.Any())
                                    throw new Exception("No es pot canviar el tipus d'empresa si ja te productes");
                            }
                            break;
                    }
                }
            }
            catch (ApplicationException ex1)
            {
                Utilitats.EscriuLog(ex1.Message);
                e.Cancel = true;
            }
            catch (Exception ex2)
            {
                Utilitats.EscriuLog(ex2);
                e.Cancel = true;
            }
        }

        private void dgvEmpreses_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvEmpreses.IsCurrentRowDirty)
            {
                pnDesaCanvisEmpreses.Enabled = true;
            }
        }

        private void dgvEmpreses_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            pnDesaCanvisEmpreses.Enabled = true;
        }

        private void dgvEmpreses_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpreses.CurrentRow != null && dgvEmpreses.CurrentRow.Index == e.RowIndex)
                return;

            vProducteSeleccionat = null;
            vEmpresaSeleccionada = (Empresa)dgvEmpreses.Rows[e.RowIndex].DataBoundItem;

            carregaGridProductes(vEmpresaSeleccionada);

            if (vEmpresaSeleccionada != null)
                colIsin.Visible = vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.GestoraFons;
        }


        private void btEsborraProducte_Click(object sender, EventArgs e)
        {
            try
            {
                if (Moviment.Tuples.Any(a => a.ProdId == vProducteSeleccionat.Id))
                    throw new ApplicationException("No es pot esborrar el producte perquè té moviments");

                Producte prod = vProducteSeleccionat;

                vConnProductes.Valoracions.RemoveRange(vConnProductes.Valoracions.Where(w => w.ProdId == prod.Id));

                vConnProductes.Productes.Remove(prod);

                vConnProductes.SaveChanges();

                Valoracio.RefrescaTaula();
                Producte.RefrescaTaula();
                ProdAccions.RefrescaTaula();
                ProdFons.RefrescaTaula();
            }
            catch (Exception ex1)
            {
                Utilitats.EscriuLog(ex1);
            }
        }

        private void btCancelaProducte_Click(object sender, EventArgs e)
        {
            ompleCampsProducte((Producte)(dgvProductes.CurrentRow == null ? null : dgvProductes.CurrentRow.DataBoundItem));

            modeConsulta();
        }

        private void tbNomProducte_TextChanged(object sender, EventArgs e)
        {
            if (!_EnModeEdicio && ((TextBoxBase)sender).Modified)
            {
                modeEdicio();
            }
        }

        private void cbTipusProducte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((IValorControlRestaurable)sender).Modified)
            {
                modeEdicio();
            }
        }

        private void btDesaCanvisEmpreses_Click(object sender, EventArgs e)
        {
            try
            {
                vConnEmpreses.SaveChanges();

                Empresa.RefrescaTaula();

                ActivaRefrescaEnTabs(this);

                pnDesaCanvisEmpreses.Enabled = false;
            }
            catch (DbEntityValidationException ex2)
            {
                Utilitats.EscriuLog(ex2);
            }
            catch (Exception ex1)
            {
                Utilitats.EscriuLog(ex1);
            }
        }

        private void btCancelaCanvisEmpreses_Click(object sender, EventArgs e)
        {
            try
            {
                carregaGridEmpreses();
                dgvEmpreses.Refresh();

                pnDesaCanvisEmpreses.Enabled = false;
            }
            catch (DbEntityValidationException ex2)
            {
                Utilitats.EscriuLog(ex2);
            }
            catch (Exception ex1)
            {
                Utilitats.EscriuLog(ex1);
            }
        }

        private void dgvProductes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductes.CurrentRow != null 
                && dgvProductes.SelectedRows.Count > 0
                && dgvProductes.CurrentRow.Index == e.RowIndex)
                return;

            vProducteSeleccionat = (Producte)dgvProductes.Rows[e.RowIndex].DataBoundItem;

            if (vProducteSeleccionat == null)
            {
                cbMercatProducte.SelectedItem = null;
                cbMonedaProducte.SelectedItem = null;
                cbTipusProducte.SelectedItem = null;
            }
            else
            {
                btDesaProducte.Enabled = false;
                btCancelaProducte.Enabled = false;

                btNouProducte.Enabled = true;
                btEsborraProducte.Enabled = true;
                btEditaProducte.Enabled = true;

                ompleCampsProducte(vProducteSeleccionat);
            }

            if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses) && vProducteSeleccionat != null)
            {
                foreach (DataGridViewRow filaEmpresa in dgvEmpreses.Rows)
                {
                    var empresa = (Empresa)filaEmpresa.DataBoundItem;

                    if (empresa.Id == vProducteSeleccionat.Empresa.Id)
                    {
                        filaEmpresa.Selected = true;
                        dgvEmpreses.FirstDisplayedScrollingRowIndex = filaEmpresa.Index;
                        vEmpresaSeleccionada = empresa;
                        break;
                    }
                }
            }
        }

        private void ntbOrdreGridProducte_TextChanged(object sender, EventArgs e)
        {
            if (!_EnModeEdicio && ((TextBoxBase)sender).Modified)
            {
                modeEdicio();
            }
        }


        private enum FiltreSeleccionat
        {
            TotesLesEmpreses,
            Fons,
            Accions
        }

        private void EmpresesProductesTab_Load(object sender, EventArgs e)
        {
            carregaGridEmpreses();

            ccbFiltres.DisplayMember = "Nom";
            ccbFiltres.ValueMember = "Id";
            //ccbFiltres.Placeholder = "Selecciona...";
            //ccbFiltres.ShowPlaceholderAlways = true;

            ccbFiltres.AddItem(new { Id = FiltreSeleccionat.TotesLesEmpreses, Nom = "Totes Les Empreses" }, false);
            ccbFiltres.AddItem(new { Id = FiltreSeleccionat.Fons, Nom = "Fons" }, true);
            ccbFiltres.AddItem(new { Id = FiltreSeleccionat.Accions, Nom = "Accions" }, true);

            // Desa la situació inicial dels filtres.
            if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses)) vFiltreEmpresesAct |= 1 << 0; // Primer bit
            if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Fons)) vFiltreEmpresesAct |= 1 << 1; // Segon bit
            if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Accions)) vFiltreEmpresesAct |= 1 << 2; // Tercer bit

            carregaDadesFiltrades();
        }

        private void tbTickerAccio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        #endregion *** Events ***}

        byte vFiltreEmpresesAct = 0;

        private void ccbFiltres_DropDownClosed(object sender, DropDownClosedEventArgs e)
        {
            if (e.Reason != DropDownCloseReason.Escape)
            {
                byte filtreEmpreses = 0;
                if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses)) filtreEmpreses |= 1 << 0; // Primer bit
                if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Fons)) filtreEmpreses |= 1 << 1; // Segon bit
                if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Accions)) filtreEmpreses |= 1 << 2; // Tercer bit

                if (filtreEmpreses != vFiltreEmpresesAct)
                {
                    carregaDadesFiltrades();

                    vFiltreEmpresesAct = filtreEmpreses;
                }
            }
        }

        private void carregaDadesFiltrades()
        {
            carregaGridEmpreses();

            if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses))
            {
                dgvEmpreses.Enabled = false;
                dgvEmpreses.DefaultCellStyle.BackColor = Color.LightGray;
                dgvEmpreses.ClearSelection();

                carregaGridProductes(null);
            }
            else
            {
                dgvEmpreses.Enabled = true;
                dgvEmpreses.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;

                carregaGridProductes(vEmpresaSeleccionada);
            }
        }
    }
}