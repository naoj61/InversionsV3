using System;

namespace Inversions.GUI
{
    partial class EmpresesProductesTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grEmpresa = new System.Windows.Forms.GroupBox();
            this.dgvEmpreses = new System.Windows.Forms.DataGridView();
            this._Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._TipusEmpresa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnDesaCanvisEmpreses = new System.Windows.Forms.Panel();
            this.btCancelaCanvisEmpreses = new System.Windows.Forms.Button();
            this.btDesaCanvisEmpreses = new System.Windows.Forms.Button();
            this.grProductes = new System.Windows.Forms.GroupBox();
            this.dgvProductes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grDescripcioProducte = new System.Windows.Forms.GroupBox();
            this.tbDescripcioProducte = new System.Windows.Forms.TextBox();
            this.flpProducte = new System.Windows.Forms.FlowLayoutPanel();
            this.grOrdreGridProducte = new System.Windows.Forms.GroupBox();
            this.ntbOrdreGridProducte = new Controls.NumericTextBox2();
            this.grIsinProducte = new System.Windows.Forms.GroupBox();
            this.tbIsinProducte = new System.Windows.Forms.TextBox();
            this.grMonedaProducte = new System.Windows.Forms.GroupBox();
            this.cbMonedaProducte = new Controls.ComboBox2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTickerExchange = new System.Windows.Forms.TextBox();
            this.ckBuscaTickerExchange = new System.Windows.Forms.CheckBox();
            this.flpAccions = new System.Windows.Forms.FlowLayoutPanel();
            this.grTicker = new System.Windows.Forms.GroupBox();
            this.tbTickerAccio = new System.Windows.Forms.TextBox();
            this.grMercatProducte = new System.Windows.Forms.GroupBox();
            this.cbMercatProducte = new Controls.ComboBox2();
            this.flpFons = new System.Windows.Forms.FlowLayoutPanel();
            this.grNomProducte = new System.Windows.Forms.GroupBox();
            this.tbNomProducte = new System.Windows.Forms.TextBox();
            this.gbTipusProducte = new System.Windows.Forms.GroupBox();
            this.cbTipusProducte = new Controls.ComboBox2();
            this.pnDesaCanvisProductes = new System.Windows.Forms.Panel();
            this.btCancelaProducte = new System.Windows.Forms.Button();
            this.btEsborraProducte = new System.Windows.Forms.Button();
            this.btEditaProducte = new System.Windows.Forms.Button();
            this.btNouProducte = new System.Windows.Forms.Button();
            this.btDesaProducte = new System.Windows.Forms.Button();
            this.ccbFiltres = new Controls.CheckedComboBoxControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._IdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._OrdreGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NomProducte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpreses)).BeginInit();
            this.pnDesaCanvisEmpreses.SuspendLayout();
            this.grProductes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductes)).BeginInit();
            this.panel1.SuspendLayout();
            this.grDescripcioProducte.SuspendLayout();
            this.flpProducte.SuspendLayout();
            this.grOrdreGridProducte.SuspendLayout();
            this.grIsinProducte.SuspendLayout();
            this.grMonedaProducte.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flpAccions.SuspendLayout();
            this.grTicker.SuspendLayout();
            this.grMercatProducte.SuspendLayout();
            this.flpFons.SuspendLayout();
            this.grNomProducte.SuspendLayout();
            this.gbTipusProducte.SuspendLayout();
            this.pnDesaCanvisProductes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grEmpresa
            // 
            this.grEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grEmpresa.Controls.Add(this.dgvEmpreses);
            this.grEmpresa.Controls.Add(this.pnDesaCanvisEmpreses);
            this.grEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grEmpresa.Location = new System.Drawing.Point(3, 71);
            this.grEmpresa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grEmpresa.Name = "grEmpresa";
            this.grEmpresa.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grEmpresa.Size = new System.Drawing.Size(906, 644);
            this.grEmpresa.TabIndex = 1;
            this.grEmpresa.TabStop = false;
            this.grEmpresa.Text = "Empreses";
            // 
            // dgvEmpreses
            // 
            this.dgvEmpreses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpreses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._Id,
            this._Nom,
            this._TipusEmpresa});
            this.dgvEmpreses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpreses.Location = new System.Drawing.Point(3, 23);
            this.dgvEmpreses.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvEmpreses.MultiSelect = false;
            this.dgvEmpreses.Name = "dgvEmpreses";
            this.dgvEmpreses.RowHeadersWidth = 25;
            this.dgvEmpreses.RowTemplate.Height = 24;
            this.dgvEmpreses.Size = new System.Drawing.Size(900, 561);
            this.dgvEmpreses.TabIndex = 0;
            this.dgvEmpreses.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvEmpreses_CellValidating);
            this.dgvEmpreses.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpreses_RowHeaderMouseClick);
            this.dgvEmpreses.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvEmpreses_RowValidating);
            this.dgvEmpreses.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvEmpreses_UserDeletedRow);
            this.dgvEmpreses.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEmpreses_UserDeletingRow);
            // 
            // _Id
            // 
            this._Id.DataPropertyName = "Id";
            this._Id.HeaderText = "Id";
            this._Id.MinimumWidth = 8;
            this._Id.Name = "_Id";
            this._Id.ReadOnly = true;
            this._Id.Width = 50;
            // 
            // _Nom
            // 
            this._Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._Nom.DataPropertyName = "Nom";
            this._Nom.HeaderText = "Nom";
            this._Nom.MinimumWidth = 8;
            this._Nom.Name = "_Nom";
            // 
            // _TipusEmpresa
            // 
            this._TipusEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._TipusEmpresa.DataPropertyName = "TipusEmpresa";
            this._TipusEmpresa.HeaderText = "Tipus Empresa";
            this._TipusEmpresa.MinimumWidth = 8;
            this._TipusEmpresa.Name = "_TipusEmpresa";
            this._TipusEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._TipusEmpresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._TipusEmpresa.Width = 151;
            // 
            // pnDesaCanvisEmpreses
            // 
            this.pnDesaCanvisEmpreses.Controls.Add(this.btCancelaCanvisEmpreses);
            this.pnDesaCanvisEmpreses.Controls.Add(this.btDesaCanvisEmpreses);
            this.pnDesaCanvisEmpreses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDesaCanvisEmpreses.Enabled = false;
            this.pnDesaCanvisEmpreses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDesaCanvisEmpreses.Location = new System.Drawing.Point(3, 584);
            this.pnDesaCanvisEmpreses.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnDesaCanvisEmpreses.Name = "pnDesaCanvisEmpreses";
            this.pnDesaCanvisEmpreses.Padding = new System.Windows.Forms.Padding(6);
            this.pnDesaCanvisEmpreses.Size = new System.Drawing.Size(900, 55);
            this.pnDesaCanvisEmpreses.TabIndex = 1;
            this.pnDesaCanvisEmpreses.Text = "Canvis pendents de desar";
            // 
            // btCancelaCanvisEmpreses
            // 
            this.btCancelaCanvisEmpreses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelaCanvisEmpreses.Location = new System.Drawing.Point(787, 11);
            this.btCancelaCanvisEmpreses.Margin = new System.Windows.Forms.Padding(0);
            this.btCancelaCanvisEmpreses.Name = "btCancelaCanvisEmpreses";
            this.btCancelaCanvisEmpreses.Size = new System.Drawing.Size(107, 39);
            this.btCancelaCanvisEmpreses.TabIndex = 1;
            this.btCancelaCanvisEmpreses.Text = "Cancel·la";
            this.btCancelaCanvisEmpreses.UseVisualStyleBackColor = true;
            this.btCancelaCanvisEmpreses.Click += new System.EventHandler(this.btCancelaCanvisEmpreses_Click);
            // 
            // btDesaCanvisEmpreses
            // 
            this.btDesaCanvisEmpreses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDesaCanvisEmpreses.Location = new System.Drawing.Point(671, 11);
            this.btDesaCanvisEmpreses.Margin = new System.Windows.Forms.Padding(0);
            this.btDesaCanvisEmpreses.Name = "btDesaCanvisEmpreses";
            this.btDesaCanvisEmpreses.Size = new System.Drawing.Size(107, 39);
            this.btDesaCanvisEmpreses.TabIndex = 0;
            this.btDesaCanvisEmpreses.Text = "Desa";
            this.btDesaCanvisEmpreses.UseVisualStyleBackColor = true;
            this.btDesaCanvisEmpreses.Click += new System.EventHandler(this.btDesaCanvisEmpreses_Click);
            // 
            // grProductes
            // 
            this.grProductes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grProductes.Controls.Add(this.dgvProductes);
            this.grProductes.Controls.Add(this.panel1);
            this.grProductes.Controls.Add(this.pnDesaCanvisProductes);
            this.grProductes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProductes.Location = new System.Drawing.Point(912, 71);
            this.grProductes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grProductes.Name = "grProductes";
            this.grProductes.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grProductes.Size = new System.Drawing.Size(788, 644);
            this.grProductes.TabIndex = 2;
            this.grProductes.TabStop = false;
            this.grProductes.Text = "Productes";
            // 
            // dgvProductes
            // 
            this.dgvProductes.AllowUserToAddRows = false;
            this.dgvProductes.AllowUserToDeleteRows = false;
            this.dgvProductes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._IdProd,
            this._OrdreGrid,
            this.colIsin,
            this._NomProducte});
            this.dgvProductes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductes.EnableHeadersVisualStyles = false;
            this.dgvProductes.Location = new System.Drawing.Point(3, 23);
            this.dgvProductes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductes.MultiSelect = false;
            this.dgvProductes.Name = "dgvProductes";
            this.dgvProductes.ReadOnly = true;
            this.dgvProductes.RowHeadersWidth = 10;
            this.dgvProductes.RowTemplate.Height = 24;
            this.dgvProductes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductes.Size = new System.Drawing.Size(782, 207);
            this.dgvProductes.TabIndex = 0;
            this.dgvProductes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductes_ColumnHeaderMouseClick);
            this.dgvProductes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductes_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grDescripcioProducte);
            this.panel1.Controls.Add(this.flpProducte);
            this.panel1.Controls.Add(this.flpAccions);
            this.panel1.Controls.Add(this.flpFons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 230);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 354);
            this.panel1.TabIndex = 5;
            // 
            // grDescripcioProducte
            // 
            this.grDescripcioProducte.Controls.Add(this.tbDescripcioProducte);
            this.grDescripcioProducte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDescripcioProducte.Location = new System.Drawing.Point(0, 267);
            this.grDescripcioProducte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDescripcioProducte.Name = "grDescripcioProducte";
            this.grDescripcioProducte.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDescripcioProducte.Size = new System.Drawing.Size(782, 87);
            this.grDescripcioProducte.TabIndex = 4;
            this.grDescripcioProducte.TabStop = false;
            this.grDescripcioProducte.Text = "Descripció";
            // 
            // tbDescripcioProducte
            // 
            this.tbDescripcioProducte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescripcioProducte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcioProducte.Location = new System.Drawing.Point(3, 22);
            this.tbDescripcioProducte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbDescripcioProducte.Multiline = true;
            this.tbDescripcioProducte.Name = "tbDescripcioProducte";
            this.tbDescripcioProducte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcioProducte.Size = new System.Drawing.Size(776, 61);
            this.tbDescripcioProducte.TabIndex = 0;
            // 
            // flpProducte
            // 
            this.flpProducte.Controls.Add(this.grOrdreGridProducte);
            this.flpProducte.Controls.Add(this.grIsinProducte);
            this.flpProducte.Controls.Add(this.grMonedaProducte);
            this.flpProducte.Controls.Add(this.groupBox2);
            this.flpProducte.Controls.Add(this.ckBuscaTickerExchange);
            this.flpProducte.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpProducte.Location = new System.Drawing.Point(0, 142);
            this.flpProducte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpProducte.Name = "flpProducte";
            this.flpProducte.Size = new System.Drawing.Size(782, 125);
            this.flpProducte.TabIndex = 6;
            // 
            // grOrdreGridProducte
            // 
            this.grOrdreGridProducte.Controls.Add(this.ntbOrdreGridProducte);
            this.grOrdreGridProducte.Location = new System.Drawing.Point(3, 4);
            this.grOrdreGridProducte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grOrdreGridProducte.Name = "grOrdreGridProducte";
            this.grOrdreGridProducte.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grOrdreGridProducte.Size = new System.Drawing.Size(116, 54);
            this.grOrdreGridProducte.TabIndex = 2;
            this.grOrdreGridProducte.TabStop = false;
            this.grOrdreGridProducte.Text = "Ordre Grid";
            // 
            // ntbOrdreGridProducte
            // 
            this.ntbOrdreGridProducte._CapturaEscape = true;
            this.ntbOrdreGridProducte._Format = "0";
            this.ntbOrdreGridProducte._NegatiusEnVermell = false;
            this.ntbOrdreGridProducte._PermetDecimals = true;
            this.ntbOrdreGridProducte._PermetNegatius = true;
            this.ntbOrdreGridProducte._PermetTextNull = false;
            this.ntbOrdreGridProducte.BackColor = System.Drawing.SystemColors.Window;
            this.ntbOrdreGridProducte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbOrdreGridProducte.Location = new System.Drawing.Point(3, 22);
            this.ntbOrdreGridProducte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ntbOrdreGridProducte.Name = "ntbOrdreGridProducte";
            this.ntbOrdreGridProducte.Size = new System.Drawing.Size(110, 25);
            this.ntbOrdreGridProducte.TabIndex = 0;
            this.ntbOrdreGridProducte.Text = "999";
            this.ntbOrdreGridProducte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbOrdreGridProducte.Valor = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // grIsinProducte
            // 
            this.grIsinProducte.Controls.Add(this.tbIsinProducte);
            this.grIsinProducte.Location = new System.Drawing.Point(125, 4);
            this.grIsinProducte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grIsinProducte.Name = "grIsinProducte";
            this.grIsinProducte.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grIsinProducte.Size = new System.Drawing.Size(294, 54);
            this.grIsinProducte.TabIndex = 0;
            this.grIsinProducte.TabStop = false;
            this.grIsinProducte.Text = "ISIN";
            // 
            // tbIsinProducte
            // 
            this.tbIsinProducte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIsinProducte.Location = new System.Drawing.Point(3, 22);
            this.tbIsinProducte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbIsinProducte.Name = "tbIsinProducte";
            this.tbIsinProducte.Size = new System.Drawing.Size(288, 25);
            this.tbIsinProducte.TabIndex = 0;
            // 
            // grMonedaProducte
            // 
            this.grMonedaProducte.Controls.Add(this.cbMonedaProducte);
            this.grMonedaProducte.Location = new System.Drawing.Point(425, 4);
            this.grMonedaProducte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grMonedaProducte.Name = "grMonedaProducte";
            this.grMonedaProducte.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grMonedaProducte.Size = new System.Drawing.Size(181, 54);
            this.grMonedaProducte.TabIndex = 1;
            this.grMonedaProducte.TabStop = false;
            this.grMonedaProducte.Text = "Moneda";
            // 
            // cbMonedaProducte
            // 
            this.cbMonedaProducte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMonedaProducte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonedaProducte.FormattingEnabled = true;
            this.cbMonedaProducte.Location = new System.Drawing.Point(3, 22);
            this.cbMonedaProducte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbMonedaProducte.Name = "cbMonedaProducte";
            this.cbMonedaProducte.Size = new System.Drawing.Size(175, 28);
            this.cbMonedaProducte.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTickerExchange);
            this.groupBox2.Location = new System.Drawing.Point(3, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(232, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticker Exchange";
            // 
            // tbTickerExchange
            // 
            this.tbTickerExchange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTickerExchange.Location = new System.Drawing.Point(3, 22);
            this.tbTickerExchange.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbTickerExchange.Name = "tbTickerExchange";
            this.tbTickerExchange.ReadOnly = true;
            this.tbTickerExchange.Size = new System.Drawing.Size(226, 25);
            this.tbTickerExchange.TabIndex = 0;
            // 
            // ckBuscaTickerExchange
            // 
            this.ckBuscaTickerExchange.AutoSize = true;
            this.ckBuscaTickerExchange.Location = new System.Drawing.Point(241, 72);
            this.ckBuscaTickerExchange.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ckBuscaTickerExchange.Name = "ckBuscaTickerExchange";
            this.ckBuscaTickerExchange.Size = new System.Drawing.Size(222, 24);
            this.ckBuscaTickerExchange.TabIndex = 3;
            this.ckBuscaTickerExchange.Text = "Busca Ticker Exchange";
            this.ckBuscaTickerExchange.UseVisualStyleBackColor = true;
            // 
            // flpAccions
            // 
            this.flpAccions.Controls.Add(this.grTicker);
            this.flpAccions.Controls.Add(this.grMercatProducte);
            this.flpAccions.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpAccions.Location = new System.Drawing.Point(0, 71);
            this.flpAccions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpAccions.Name = "flpAccions";
            this.flpAccions.Size = new System.Drawing.Size(782, 71);
            this.flpAccions.TabIndex = 3;
            // 
            // grTicker
            // 
            this.grTicker.Controls.Add(this.tbTickerAccio);
            this.grTicker.Location = new System.Drawing.Point(3, 4);
            this.grTicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grTicker.Name = "grTicker";
            this.grTicker.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grTicker.Size = new System.Drawing.Size(111, 54);
            this.grTicker.TabIndex = 2;
            this.grTicker.TabStop = false;
            this.grTicker.Text = "Ticker";
            // 
            // tbTickerAccio
            // 
            this.tbTickerAccio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTickerAccio.Location = new System.Drawing.Point(3, 22);
            this.tbTickerAccio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbTickerAccio.Name = "tbTickerAccio";
            this.tbTickerAccio.Size = new System.Drawing.Size(105, 25);
            this.tbTickerAccio.TabIndex = 1;
            this.tbTickerAccio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTickerAccio_KeyPress);
            // 
            // grMercatProducte
            // 
            this.grMercatProducte.Controls.Add(this.cbMercatProducte);
            this.grMercatProducte.Location = new System.Drawing.Point(120, 4);
            this.grMercatProducte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grMercatProducte.Name = "grMercatProducte";
            this.grMercatProducte.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grMercatProducte.Size = new System.Drawing.Size(126, 54);
            this.grMercatProducte.TabIndex = 1;
            this.grMercatProducte.TabStop = false;
            this.grMercatProducte.Text = "Mercat";
            // 
            // cbMercatProducte
            // 
            this.cbMercatProducte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMercatProducte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMercatProducte.FormattingEnabled = true;
            this.cbMercatProducte.Location = new System.Drawing.Point(3, 22);
            this.cbMercatProducte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbMercatProducte.Name = "cbMercatProducte";
            this.cbMercatProducte.Size = new System.Drawing.Size(120, 28);
            this.cbMercatProducte.TabIndex = 0;
            // 
            // flpFons
            // 
            this.flpFons.Controls.Add(this.grNomProducte);
            this.flpFons.Controls.Add(this.gbTipusProducte);
            this.flpFons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpFons.Location = new System.Drawing.Point(0, 0);
            this.flpFons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpFons.Name = "flpFons";
            this.flpFons.Size = new System.Drawing.Size(782, 71);
            this.flpFons.TabIndex = 2;
            // 
            // grNomProducte
            // 
            this.grNomProducte.Controls.Add(this.tbNomProducte);
            this.grNomProducte.Location = new System.Drawing.Point(3, 4);
            this.grNomProducte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grNomProducte.Name = "grNomProducte";
            this.grNomProducte.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grNomProducte.Size = new System.Drawing.Size(367, 54);
            this.grNomProducte.TabIndex = 0;
            this.grNomProducte.TabStop = false;
            this.grNomProducte.Text = "Nom";
            // 
            // tbNomProducte
            // 
            this.tbNomProducte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNomProducte.Location = new System.Drawing.Point(3, 22);
            this.tbNomProducte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbNomProducte.Name = "tbNomProducte";
            this.tbNomProducte.Size = new System.Drawing.Size(361, 25);
            this.tbNomProducte.TabIndex = 0;
            // 
            // gbTipusProducte
            // 
            this.gbTipusProducte.Controls.Add(this.cbTipusProducte);
            this.gbTipusProducte.Location = new System.Drawing.Point(376, 4);
            this.gbTipusProducte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTipusProducte.Name = "gbTipusProducte";
            this.gbTipusProducte.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTipusProducte.Size = new System.Drawing.Size(99, 54);
            this.gbTipusProducte.TabIndex = 1;
            this.gbTipusProducte.TabStop = false;
            this.gbTipusProducte.Text = "Tipus";
            // 
            // cbTipusProducte
            // 
            this.cbTipusProducte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTipusProducte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipusProducte.FormattingEnabled = true;
            this.cbTipusProducte.Location = new System.Drawing.Point(3, 22);
            this.cbTipusProducte.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbTipusProducte.Name = "cbTipusProducte";
            this.cbTipusProducte.Size = new System.Drawing.Size(93, 28);
            this.cbTipusProducte.TabIndex = 0;
            this.cbTipusProducte.SelectedIndexChanged += new System.EventHandler(this.cbTipusProducte_SelectedIndexChanged);
            // 
            // pnDesaCanvisProductes
            // 
            this.pnDesaCanvisProductes.Controls.Add(this.btCancelaProducte);
            this.pnDesaCanvisProductes.Controls.Add(this.btEsborraProducte);
            this.pnDesaCanvisProductes.Controls.Add(this.btEditaProducte);
            this.pnDesaCanvisProductes.Controls.Add(this.btNouProducte);
            this.pnDesaCanvisProductes.Controls.Add(this.btDesaProducte);
            this.pnDesaCanvisProductes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDesaCanvisProductes.Location = new System.Drawing.Point(3, 584);
            this.pnDesaCanvisProductes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnDesaCanvisProductes.Name = "pnDesaCanvisProductes";
            this.pnDesaCanvisProductes.Size = new System.Drawing.Size(782, 55);
            this.pnDesaCanvisProductes.TabIndex = 5;
            // 
            // btCancelaProducte
            // 
            this.btCancelaProducte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelaProducte.Location = new System.Drawing.Point(665, 11);
            this.btCancelaProducte.Margin = new System.Windows.Forms.Padding(0);
            this.btCancelaProducte.Name = "btCancelaProducte";
            this.btCancelaProducte.Size = new System.Drawing.Size(107, 39);
            this.btCancelaProducte.TabIndex = 4;
            this.btCancelaProducte.Text = "Cancel·la";
            this.btCancelaProducte.UseVisualStyleBackColor = true;
            this.btCancelaProducte.Click += new System.EventHandler(this.btCancelaProducte_Click);
            // 
            // btEsborraProducte
            // 
            this.btEsborraProducte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEsborraProducte.Location = new System.Drawing.Point(130, 11);
            this.btEsborraProducte.Margin = new System.Windows.Forms.Padding(0);
            this.btEsborraProducte.Name = "btEsborraProducte";
            this.btEsborraProducte.Size = new System.Drawing.Size(107, 39);
            this.btEsborraProducte.TabIndex = 1;
            this.btEsborraProducte.Text = "Esborra";
            this.btEsborraProducte.UseVisualStyleBackColor = true;
            this.btEsborraProducte.Click += new System.EventHandler(this.btEsborraProducte_Click);
            // 
            // btEditaProducte
            // 
            this.btEditaProducte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditaProducte.Location = new System.Drawing.Point(250, 11);
            this.btEditaProducte.Margin = new System.Windows.Forms.Padding(0);
            this.btEditaProducte.Name = "btEditaProducte";
            this.btEditaProducte.Size = new System.Drawing.Size(107, 39);
            this.btEditaProducte.TabIndex = 2;
            this.btEditaProducte.Text = "Edita";
            this.btEditaProducte.UseVisualStyleBackColor = true;
            this.btEditaProducte.Click += new System.EventHandler(this.btEditaProducte_Click);
            // 
            // btNouProducte
            // 
            this.btNouProducte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNouProducte.Location = new System.Drawing.Point(14, 11);
            this.btNouProducte.Margin = new System.Windows.Forms.Padding(0);
            this.btNouProducte.Name = "btNouProducte";
            this.btNouProducte.Size = new System.Drawing.Size(107, 39);
            this.btNouProducte.TabIndex = 0;
            this.btNouProducte.Text = "Nou";
            this.btNouProducte.UseVisualStyleBackColor = true;
            this.btNouProducte.Click += new System.EventHandler(this.btNouProducte_Click);
            // 
            // btDesaProducte
            // 
            this.btDesaProducte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDesaProducte.Location = new System.Drawing.Point(547, 11);
            this.btDesaProducte.Margin = new System.Windows.Forms.Padding(0);
            this.btDesaProducte.Name = "btDesaProducte";
            this.btDesaProducte.Size = new System.Drawing.Size(107, 39);
            this.btDesaProducte.TabIndex = 3;
            this.btDesaProducte.Text = "Desa";
            this.btDesaProducte.UseVisualStyleBackColor = true;
            this.btDesaProducte.Click += new System.EventHandler(this.btDesaProducte_Click);
            // 
            // ccbFiltres
            // 
            this.ccbFiltres.CountFormat = "{0} seleccionats";
            this.ccbFiltres.DisplayMember = null;
            this.ccbFiltres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ccbFiltres.Location = new System.Drawing.Point(3, 22);
            this.ccbFiltres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ccbFiltres.Name = "ccbFiltres";
            this.ccbFiltres.Placeholder = "Selecciona...";
            this.ccbFiltres.Separator = ", ";
            this.ccbFiltres.ShowCountInsteadOfList = false;
            this.ccbFiltres.ShowPlaceholderAlways = false;
            this.ccbFiltres.Size = new System.Drawing.Size(278, 39);
            this.ccbFiltres.TabIndex = 3;
            this.ccbFiltres.ValueMember = null;
            this.ccbFiltres.DropDownClosed += new System.EventHandler<Controls.DropDownClosedEventArgs>(this.ccbFiltres_DropDownClosed);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ccbFiltres);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(284, 65);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtres";
            // 
            // _IdProd
            // 
            this._IdProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._IdProd.DataPropertyName = "Id";
            this._IdProd.HeaderText = "Id";
            this._IdProd.MinimumWidth = 8;
            this._IdProd.Name = "_IdProd";
            this._IdProd.ReadOnly = true;
            this._IdProd.Width = 61;
            // 
            // _OrdreGrid
            // 
            this._OrdreGrid.DataPropertyName = "OrdreGrid";
            this._OrdreGrid.HeaderText = "Ordre Grid";
            this._OrdreGrid.MinimumWidth = 8;
            this._OrdreGrid.Name = "_OrdreGrid";
            this._OrdreGrid.ReadOnly = true;
            this._OrdreGrid.Width = 150;
            // 
            // colIsin
            // 
            this.colIsin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colIsin.DataPropertyName = "ISIN";
            this.colIsin.HeaderText = "ISIN";
            this.colIsin.MinimumWidth = 8;
            this.colIsin.Name = "colIsin";
            this.colIsin.ReadOnly = true;
            this.colIsin.Width = 81;
            // 
            // _NomProducte
            // 
            this._NomProducte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._NomProducte.DataPropertyName = "_NomProducte";
            this._NomProducte.HeaderText = "Nom";
            this._NomProducte.MinimumWidth = 200;
            this._NomProducte.Name = "_NomProducte";
            this._NomProducte.ReadOnly = true;
            // 
            // EmpresesProductesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grProductes);
            this.Controls.Add(this.grEmpresa);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MinimumSize = new System.Drawing.Size(1464, 819);
            this.Name = "EmpresesProductesTab";
            this.Size = new System.Drawing.Size(1703, 819);
            this.Load += new System.EventHandler(this.EmpresesProductesTab_Load);
            this.grEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpreses)).EndInit();
            this.pnDesaCanvisEmpreses.ResumeLayout(false);
            this.grProductes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grDescripcioProducte.ResumeLayout(false);
            this.grDescripcioProducte.PerformLayout();
            this.flpProducte.ResumeLayout(false);
            this.flpProducte.PerformLayout();
            this.grOrdreGridProducte.ResumeLayout(false);
            this.grOrdreGridProducte.PerformLayout();
            this.grIsinProducte.ResumeLayout(false);
            this.grIsinProducte.PerformLayout();
            this.grMonedaProducte.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flpAccions.ResumeLayout(false);
            this.grTicker.ResumeLayout(false);
            this.grTicker.PerformLayout();
            this.grMercatProducte.ResumeLayout(false);
            this.flpFons.ResumeLayout(false);
            this.grNomProducte.ResumeLayout(false);
            this.grNomProducte.PerformLayout();
            this.gbTipusProducte.ResumeLayout(false);
            this.pnDesaCanvisProductes.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grEmpresa;
        private System.Windows.Forms.Panel pnDesaCanvisEmpreses;
        private System.Windows.Forms.Button btCancelaCanvisEmpreses;
        private System.Windows.Forms.Button btDesaCanvisEmpreses;
        private System.Windows.Forms.GroupBox grProductes;
        private System.Windows.Forms.GroupBox grIsinProducte;
        private System.Windows.Forms.TextBox tbIsinProducte;
        private System.Windows.Forms.Panel pnDesaCanvisProductes;
        private System.Windows.Forms.Button btCancelaProducte;
        private System.Windows.Forms.Button btEsborraProducte;
        private System.Windows.Forms.Button btEditaProducte;
        private System.Windows.Forms.Button btNouProducte;
        private System.Windows.Forms.Button btDesaProducte;
        private System.Windows.Forms.GroupBox grTicker;
        private System.Windows.Forms.GroupBox grDescripcioProducte;
        private System.Windows.Forms.TextBox tbDescripcioProducte;
        private System.Windows.Forms.GroupBox gbTipusProducte;
        private Controls.ComboBox2 cbTipusProducte;
        private System.Windows.Forms.GroupBox grMercatProducte;
        private Controls.ComboBox2 cbMercatProducte;
        private System.Windows.Forms.DataGridView dgvProductes;
        private System.Windows.Forms.FlowLayoutPanel flpAccions;
        private System.Windows.Forms.FlowLayoutPanel flpFons;
        private System.Windows.Forms.TextBox tbTickerAccio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTickerExchange;
        private Controls.CheckedComboBoxControl ccbFiltres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEmpreses;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Nom;
        private System.Windows.Forms.DataGridViewComboBoxColumn _TipusEmpresa;
        private System.Windows.Forms.FlowLayoutPanel flpProducte;
        private System.Windows.Forms.GroupBox grNomProducte;
        private System.Windows.Forms.TextBox tbNomProducte;
        private System.Windows.Forms.GroupBox grOrdreGridProducte;
        private Controls.NumericTextBox2 ntbOrdreGridProducte;
        private System.Windows.Forms.GroupBox grMonedaProducte;
        private Controls.ComboBox2 cbMonedaProducte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckBuscaTickerExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn _OrdreGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsin;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NomProducte;
    }
}
