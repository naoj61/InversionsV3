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
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using static Inversions.ClassesEntity.Producte;

namespace Inversions.GUI
{
    public partial class EmpresesProductesTab : TabX
    {
        private InversionsBDContext vConnEmpreses;
        private InversionsBDContext vConnProductes;

        private Empresa vEmpresaSeleccionada;
        private Producte vProducteSeleccionat;
        private BindingSource vBindingSourceEmpreses = new BindingSource();
        private byte vFiltreEmpresesAct = 0;

        private enum FiltreSeleccionat
        {
            TotesLesEmpreses,
            Fons,
            Accions
        }

        public EmpresesProductesTab()
        {
            InitializeComponent();

            dgvEmpreses.AutoGenerateColumns = false;
            dgvProductes.AutoGenerateColumns = false;

            // Carrega els tipus d'empresa al combo de la grid.
            ((DataGridViewComboBoxColumn)dgvEmpreses.Columns["_TipusEmpresa"])
                .DataSource = Enum.GetValues(typeof(TipusEmpresa)); ;
        }

        #region *** Mètodes ***

        /// <summary>
        /// Mostra o amaga els controls en funvio del tipus d'empresa seleccionada.
        /// </summary>
        private void preparaControlsProducte()
        {
            if (vEmpresaSeleccionada == null)
                return;

            if (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.Accions)
            {
                flpFons.Visible = false;
                flpAccions.Visible = true;
                grDescripcioProducte.Visible = false;
            }
            else if (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.GestoraFons)
            {
                flpFons.Visible = true;
                flpAccions.Visible = false;
                grDescripcioProducte.Visible = true;
            }
        }

        private void carregaGridEmpreses()
        {
            // Creo la connexió per utilitzar-la a desar les modificacions.
            vConnEmpreses = new InversionsBDContext();

            // Carrega les empreses segons els filtres seleccionats.
            if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Accions))
                vConnEmpreses.Empreses.Where(e => e.TipusEmpresa == TipusEmpresa.Accions).Load();

            if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Fons))
                vConnEmpreses.Empreses.Where(e => e.TipusEmpresa == TipusEmpresa.GestoraFons).Load();

            dgvEmpreses.RowEnter -= dgvEmpreses_RowEnter;

            vBindingSourceEmpreses.DataSource = vConnEmpreses.Empreses.Local.ToBindingList();
            dgvEmpreses.DataSource = vBindingSourceEmpreses;

            dgvEmpreses.Sort(dgvEmpreses.Columns["_Id"], ListSortDirection.Ascending);

            if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses))
            {
                dgvEmpreses.ReadOnly = true;
                dgvEmpreses.DefaultCellStyle.BackColor = Color.LightGray;

                // Evita que es seleccionin les empreses quan es mostren totes les empreses,
                // ja que poden ser de tipus diferent i això fa que no es mostrin els productes.
                dgvEmpreses.SelectionChanged += dgvEmpreses_SelectionChanged;

                carregaGridProductes(null);
            }
            else
            {
                dgvEmpreses.ReadOnly = false;
                dgvEmpreses.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;

                // Permet seleccionar les empreses quan no es mostren totes les empreses,
                // per veure els productes associats a cada empresa.
                dgvEmpreses.SelectionChanged -= dgvEmpreses_SelectionChanged;
                dgvEmpreses.RowEnter += dgvEmpreses_RowEnter;

                dgvProductes.DataSource = null;
            }

            dgvEmpreses.CurrentCell = null;
            dgvEmpreses.ClearSelection();
        }

        private void carregaGridProductes(Empresa empresa)
        {
            List<Producte> productes = new List<Producte>();

            if (empresa == null)
            {

                if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses))
                {
                    // Carrega els Productes segons els filtres seleccionats.
                    if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Accions))
                        productes.AddRange(Program.Sessio.Productes
                            .Where(e => e.Empresa.TipusEmpresa == TipusEmpresa.Accions));

                    if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Fons))
                        productes.AddRange(Program.Sessio.Productes
                            .Where(e => e.Empresa.TipusEmpresa == TipusEmpresa.GestoraFons));

                    dgvProductes.DataSource = productes.OrderBy(o => o.Id).ToList();
                }
            }
            else
            {
                dgvProductes.DataSource = Program.Sessio.Productes
                    .Where(w => w.EmpresaId == empresa.Id).ToList();
            }

            dgvProductes.ClearSelection();

            if (((ICollection)dgvProductes.DataSource).Count == 1)
                dgvProductes.Rows[0].Selected = true;


            if (((ICollection)dgvProductes.DataSource).Count == 0
                || dgvProductes.SelectedRows.Count == 0)
            {
                tbNomProducte.Text = String.Empty;
                tbTickerExchange.Text = String.Empty;
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
                tbTickerExchange.Text = String.Empty;
                ntbOrdreGridProducte.Valor = 0;
                cbMercatProducte.SelectedItem = null;
                cbMonedaProducte.SelectedItem = null;
                cbTipusProducte.SelectedItem = null;
                cbTipusProducte.SelectedText = String.Empty;
                tbIsinProducte.Text = String.Empty;
                tbTickerAccio.Text = String.Empty;
                tbDescripcioProducte.Text = String.Empty;
            }
            else
            {
                tbNomProducte.Text = producte._NomProducte;
                ntbOrdreGridProducte.Valor = producte.OrdreGrid.GetValueOrDefault();
                cbMonedaProducte.SelectedItem = producte.Moneda;
                tbTickerExchange.Text = producte.TickerExchange;

                if (producte is ProdAccions)
                {
                    tbTickerAccio.Text = ((ProdAccions)producte).Ticker;
                    cbMercatProducte.SelectedItem = producte._Mercat;
                }
                else if (producte is ProdFons)
                {
                    tbIsinProducte.Text = producte._Isin;
                    tbDescripcioProducte.Text = producte._Descripcio;
                    cbTipusProducte.SelectedItem = ((ProdFons)producte).Tipus;
                }
            }
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
            ckBuscaTickerExchange.Enabled = true;
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
            ckBuscaTickerExchange.Enabled = false;
            ckBuscaTickerExchange.Checked = false;
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


        private void desaCanvisEmpreses()
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

        #endregion *** Mètodes ***


        #region *** Events ***
        private void EmpresesProductesTab_Load(object sender, EventArgs e)
        {
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

            carregaGridEmpreses();
        }

        private void btEditaProducte_Click(object sender, EventArgs e)
        {
            modeEdicio();
        }

        private void btNouProducte_Click(object sender, EventArgs e)
        {
            if (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.Accions)
            {
                vProducteSeleccionat = new ProdAccions();

            }
            else if (vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.GestoraFons)
            {
                vProducteSeleccionat = new ProdFons();
            }
            else
            {
                vProducteSeleccionat = null;
            }

            ompleCampsProducte(vProducteSeleccionat);
            modeEdicio();
        }


        private async void btDesaProducte_Click(object sender, EventArgs e)
        {
            try
            {
                if (vProducteSeleccionat is ProdFons && String.IsNullOrWhiteSpace(tbNomProducte.Text))
                    throw new ApplicationException("El nom del producte no pot ser buit");
                if (cbMonedaProducte.SelectedItem == null)
                    throw new ApplicationException("S'ha de seleccionar una moneda");
                if (vProducteSeleccionat is ProdAccions && cbMercatProducte.SelectedItem == null)
                    throw new ApplicationException("S'ha de seleccionar un mercat");


                using (var conn = new InversionsBDContext())
                {
                    Producte prod = vProducteSeleccionat;
                    //var prod = conn.Productes.Find(vProducteSeleccionat.Id);

                    var empresa = (Empresa)prod.Empresa;

                    bool esProdNou = prod.Id == 0;

                    if (esProdNou)
                    {
                        prod = empresa.TipusEmpresa == TipusEmpresa.Accions
                        ? (Producte)conn.ProdAccions.Create()
                        : (Producte)conn.ProdFons.Create();

                        // Producte nou
                        prod.EmpresaId = empresa.Id;
                    }

                    prod.MonedaCodi = ((Moneda)cbMonedaProducte.SelectedItem).Codi;
                    prod.OrdreGrid = ntbOrdreGridProducte._IntValue;

                    string tickerIsin = null;

                    if (vProducteSeleccionat is ProdAccions)
                    {
                        var prodAccio = (ProdAccions)prod;

                        var ticker = String.IsNullOrWhiteSpace(tbTickerAccio.Text)
                        ? null : tbTickerAccio.Text.Trim().ToUpper();

                        if (ckBuscaTickerExchange.Checked)
                            tickerIsin = ticker;

                        prodAccio.MercatId = ((Mercat)cbMercatProducte.SelectedItem).Id;
                        prodAccio.Ticker = ticker;
                    }
                    else
                    {
                        var prodFons = (ProdFons)prod;

                        var isin = String.IsNullOrWhiteSpace(tbIsinProducte.Text)
                        ? null : tbIsinProducte.Text.Trim().ToUpper();

                        if (ckBuscaTickerExchange.Checked)
                            tickerIsin = isin;

                        prodFons.Nom = tbNomProducte.Text;
                        prodFons.ISIN = isin;
                        prodFons.Tipus = (TipusFons)cbTipusProducte.SelectedItem;
                        prodFons.Descripcio = tbDescripcioProducte.Text;
                    }

                    if (string.IsNullOrWhiteSpace(tickerIsin))
                        prod.TickerExchange = null;
                    else
                    {
                        try
                        {
                            var tickerExchange = await EodhdUserService.GetTicker(tickerIsin);
                            if (tickerExchange != null)
                            {
                                prod.TickerExchange = tickerExchange;
                            }
                        }
                        catch (EodhdApiException ex)
                        {
                            MessageBox.Show($"No s'ha pogut obtenir el ticker exchange de la acció. \nError: {ex.Message}"
                                , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (esProdNou)
                        conn.Productes.Add(prod);
                    else
                        conn.Productes.AddOrUpdate(prod);

                    conn.SaveChanges();

                    Producte.RefrescaTaula();

                    if (prod is ProdAccions)
                        ProdAccions.RefrescaTaula();
                    else
                        ProdFons.RefrescaTaula();

                    ActivaRefrescaEnTabs(this);

                    // Refresca la grid de productes i manté la selecció a la mateixa fila que abans de refrescar
                    // , si encara existeix.
                    var filaSeleccionada = dgvProductes.SelectedRows[0].Index;
                    var primeraFilaMostrada = dgvProductes.FirstDisplayedScrollingRowIndex;

                    dgvProductes.ClearSelection();

                    if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses))
                        carregaGridProductes(null);
                    else
                        carregaGridProductes(prod.Empresa);

                    dgvProductes.CurrentCell = dgvProductes.Rows[filaSeleccionada].Cells[0];
                    dgvProductes.FirstDisplayedScrollingRowIndex = primeraFilaMostrada;

                    modeConsulta();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                var errorMessages = dbEx.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                string fullErrorMessage = string.Join("; ", errorMessages);
                MessageBox.Show(fullErrorMessage, "Error de validació", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Exception xx = Utilitats.ExtreuInnerException(ex);
                MessageBox.Show(xx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEsborraProducte_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new InversionsBDContext())
                {
                    if (Moviment.Tuples.Any(a => a.ProdId == vProducteSeleccionat.Id))
                        throw new ApplicationException("No es pot esborrar el producte perquè té moviments");

                    var prod = conn.Productes.Find(vProducteSeleccionat.Id);

                    conn.Valoracions.RemoveRange(conn.Valoracions.Where(w => w.ProdId == prod.Id));

                    conn.Productes.Remove(prod);

                    conn.SaveChanges();

                    Valoracio.RefrescaTaula();
                    Producte.RefrescaTaula();
                    ProdAccions.RefrescaTaula();
                    ProdFons.RefrescaTaula();

                    carregaGridProductes(vEmpresaSeleccionada);
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                var errorMessages = dbEx.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                string fullErrorMessage = string.Join("; ", errorMessages);
                MessageBox.Show(fullErrorMessage, "Error de validació", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Exception xx = Utilitats.ExtreuInnerException(ex);
                MessageBox.Show(xx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelaProducte_Click(object sender, EventArgs e)
        {
            ompleCampsProducte((Producte)(dgvProductes.CurrentRow == null ? null : dgvProductes.CurrentRow.DataBoundItem));

            modeConsulta();
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
                                {
                                    //throw new Exception("No es pot canviar el tipus d'empresa si ja te productes");
                                    MessageBox.Show("No es pot canviar el tipus d'empresa si ja te productes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cela.Value = valorInicial;
                                    e.Cancel = true;
                                }
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

            colIsin.Visible = vEmpresaSeleccionada != null &&
                vEmpresaSeleccionada.TipusEmpresa == TipusEmpresa.GestoraFons;
        }

        private void dgvProductes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductes.CurrentRow != null
                && dgvProductes.SelectedRows.Count > 0
                && dgvProductes.CurrentRow.Index == e.RowIndex
                || dgvProductes.Rows.Count == 0)
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
                if (ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses))
                {
                    foreach (DataGridViewRow filaEmpresa in dgvEmpreses.Rows)
                    {
                        var empresa = (Empresa)filaEmpresa.DataBoundItem;

                        if (empresa != null && empresa.Id == vProducteSeleccionat.Empresa.Id)
                        {
                            filaEmpresa.Selected = true;
                            dgvEmpreses.FirstDisplayedScrollingRowIndex = filaEmpresa.Index;
                            vEmpresaSeleccionada = empresa;
                            break;
                        }
                    }
                }

                btDesaProducte.Enabled = false;
                btCancelaProducte.Enabled = false;

                btNouProducte.Enabled = vProducteSeleccionat is ProdFons;
                btEsborraProducte.Enabled = true;
                btEditaProducte.Enabled = true;

                ompleCampsProducte(vProducteSeleccionat);
            }
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
            desaCanvisEmpreses();
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

        private void ntbOrdreGridProducte_TextChanged(object sender, EventArgs e)
        {
            if (!_EnModeEdicio && ((TextBoxBase)sender).Modified)
            {
                modeEdicio();
            }
        }

        private void tbTickerAccio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Converteix a majúscula el que s'escriu al ticker de les accions.
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

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
                    carregaGridEmpreses();

                    vFiltreEmpresesAct = filtreEmpreses;
                }

                colIsin.Visible = ccbFiltres.IsCheckedByValue(FiltreSeleccionat.TotesLesEmpreses)
                    && ccbFiltres.IsCheckedByValue(FiltreSeleccionat.Fons);
            }
        }

        int lastSortedColumnIndex = -1;

        /// <summary>
        /// Per ordenar els productes mostrats a la grid de productes segons la columna del header que s'ha clicat.
        /// Handles the mouse click event on a DataGridView 
        /// column header to sort the displayed list of  products by the selected column.
        /// </summary>
        /// <remarks>Sorting is performed based on the property of the Producte class corresponding 
        /// to the clicked column. The DataGridView's DataSource is updated to reflect the new sorted order. 
        /// Only columns with
        /// supported sorting logic are affected.</remarks>
        /// <param name="sender">The source of the event, typically the DataGridView control 
        /// whose column header was clicked.</param>
        /// <param name="e">An object containing event data, 
        /// including the index of the column header that was clicked.</param>
        private void dgvProductes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var productes = (List<Producte>)dgvProductes.DataSource;

            switch (e.ColumnIndex)
            {
                case 0: // Id
                    if (lastSortedColumnIndex == e.ColumnIndex)
                    {
                        // Si se hace clic nuevamente en la misma columna, invertir el orden
                        dgvProductes.DataSource = productes.OrderByDescending(o => o.Id).ToList();
                        lastSortedColumnIndex = -1; // Reiniciar para permitir ordenar de nuevo
                    }
                    else
                    {
                        dgvProductes.DataSource = productes.OrderBy(o => o.Id).ToList();
                        lastSortedColumnIndex = e.ColumnIndex;
                    }
                    break;
                case 1: // OrdreGrid
                    if (lastSortedColumnIndex == e.ColumnIndex)
                    {
                        // Si se hace clic nuevamente en la misma columna, invertir el orden
                        dgvProductes.DataSource = productes.OrderByDescending(o => o.OrdreGrid).ToList();
                        lastSortedColumnIndex = -1; // Reiniciar para permitir ordenar de nuevo
                    }
                    else
                    {
                        dgvProductes.DataSource = productes.OrderBy(o => o.OrdreGrid).ToList();
                        lastSortedColumnIndex = e.ColumnIndex;
                    }
                    break;
                case 2: // ISIN
                    if (lastSortedColumnIndex == e.ColumnIndex)
                    {
                        // Si se hace clic nuevamente en la misma columna, invertir el orden
                        dgvProductes.DataSource = productes.OrderByDescending(o => o._Isin).ToList();
                        lastSortedColumnIndex = -1; // Reiniciar para permitir ordenar de nuevo
                    }
                    else
                    {
                        dgvProductes.DataSource = productes.OrderBy(o => o._Isin).ToList();
                        lastSortedColumnIndex = e.ColumnIndex;
                    }
                    break;
                case 3: // Nom
                    if (lastSortedColumnIndex == e.ColumnIndex)
                    {
                        // Si se hace clic nuevamente en la misma columna, invertir el orden
                        dgvProductes.DataSource = productes.OrderByDescending(o => o._NomProducte).ToList();
                        lastSortedColumnIndex = -1; // Reiniciar para permitir ordenar de nuevo
                    }
                    else
                    {
                        dgvProductes.DataSource = productes.OrderBy(o => o._NomProducte).ToList();
                        lastSortedColumnIndex = e.ColumnIndex;
                    }
                    break;
            }
        }

        private void dgvEmpreses_SelectionChanged(object sender, EventArgs e)
        {
            dgvEmpreses.ClearSelection();
        }

        private void dgvEmpreses_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var emp = e.Row.DataBoundItem as Empresa;
            if (emp == null)
                return;

            // Exemple de validació: no permetre eliminar si té productes
            if (emp.Productes != null && emp.Productes.Any())
            {
                MessageBox.Show("No es pot eliminar l'empresa perquè té productes associats.");
                e.Cancel = true;   // ❗ Atura l’esborrat
                return;
            }

            if (MessageBox.Show($"Segur que vols eliminar l'empresa : {emp.Nom}?", "Confirmació"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;   // ❗ Atura l’esborrat
            }

            desaCanvisEmpreses();
        }

        #endregion *** Events ***}

        private void dgvEmpreses_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                dgvEmpreses.CurrentCell = dgvEmpreses.Rows[e.RowIndex].Cells[1];

//            MessageBox.Show(
//    $"SelectedRows: {dgvEmpreses.SelectedRows.Count}\n" +
//    $"CurrentCell: {dgvEmpreses.CurrentCell}"
//);
        }
    }
}