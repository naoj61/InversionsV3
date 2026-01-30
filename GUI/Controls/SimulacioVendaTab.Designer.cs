using System;
using Controls;

namespace Inversions.GUI
{
    partial class SimulacioVendaTab
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCompresOriginals = new Controls.DataGridView3();
            this.fonsOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsDisp = new Controls.NumericTextBoxColumn2();
            this.PigDeLaCompra = new Controls.NumericTextBoxColumn2();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompraOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PigOrigen = new Controls.NumericTextBoxColumn2();
            this.PigOrigenDisponible = new Controls.NumericTextBoxColumn2();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsUtil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PigOrigenUtil = new Controls.NumericTextBoxColumn2();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMaxParts = new System.Windows.Forms.Button();
            this.btMaxPartsNoTributa = new System.Windows.Forms.Button();
            this.lbParcialLliure = new System.Windows.Forms.Label();
            this.lbTotPle = new System.Windows.Forms.Label();
            this.lbTotLliure = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.ntbNumPartsSelect = new Controls.NumericTextBox2();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ntbDividents = new Controls.NumericTextBox2();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ntbIngressosExterns = new Controls.NumericTextBox2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ntbPerduesAnysAnteriors = new Controls.NumericTextBox2();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.ntbPigAltresProductes = new Controls.NumericTextBox2();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.ntbTramExentAnual = new Controls.NumericTextBox2();
            this.gbPigRealAny = new System.Windows.Forms.GroupBox();
            this.ntbPiGActual = new Controls.NumericTextBox2();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ntbRestaTramNoTributa = new Controls.NumericTextBox2();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.ntbPartsSaltades = new Controls.NumericTextBox2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ntbNumParticipacions = new Controls.NumericTextBox2();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ntbPreuParticipacio = new Controls.NumericTextBox2();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.ntbTributaRenda = new Controls.NumericTextBox2();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ntbImportBrut = new Controls.NumericTextBox2();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbAny = new System.Windows.Forms.ComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.ntbPigSimulacio = new Controls.NumericTextBox2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ntbPigOrigSimulacio = new Controls.NumericTextBox2();
            this.btRecalcula = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ctrProductes = new Inversions.GUI.GestioProductes();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompresOriginals)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.gbPigRealAny.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCompresOriginals);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 321);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 241);
            this.panel1.TabIndex = 0;
            // 
            // dgvCompresOriginals
            // 
            this.dgvCompresOriginals.AllowUserToAddRows = false;
            this.dgvCompresOriginals.AllowUserToDeleteRows = false;
            this.dgvCompresOriginals.AllowUserToOrderColumns = true;
            this.dgvCompresOriginals.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompresOriginals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCompresOriginals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompresOriginals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fonsOrig,
            this.Id,
            this.DataCompra,
            this.Parts,
            this.PartsDisp,
            this.PigDeLaCompra,
            this.Column1,
            this.IdOrig,
            this.DataCompraOrig,
            this.PigOrigen,
            this.PigOrigenDisponible,
            this.Column2,
            this.PartsUtil,
            this.PigOrigenUtil,
            this.Column3,
            this.ValorAct});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompresOriginals.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvCompresOriginals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompresOriginals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompresOriginals.Location = new System.Drawing.Point(449, 0);
            this.dgvCompresOriginals.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvCompresOriginals.Name = "dgvCompresOriginals";
            this.dgvCompresOriginals.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompresOriginals.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvCompresOriginals.RowHeadersVisible = false;
            this.dgvCompresOriginals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCompresOriginals.RowTemplate.Height = 24;
            this.dgvCompresOriginals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompresOriginals.Size = new System.Drawing.Size(576, 241);
            this.dgvCompresOriginals.TabIndex = 1;
            this.dgvCompresOriginals.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCompresOriginals_CellFormatting);
            this.dgvCompresOriginals.SelectionChanged += new System.EventHandler(this.dgvCompresOriginals_SelectionChanged);
            // 
            // fonsOrig
            // 
            this.fonsOrig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fonsOrig.DataPropertyName = "_FonsOrig";
            this.fonsOrig.HeaderText = "Fons Orig";
            this.fonsOrig.MinimumWidth = 75;
            this.fonsOrig.Name = "fonsOrig";
            this.fonsOrig.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Id.DataPropertyName = "_Id";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle17;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 20;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 20;
            // 
            // DataCompra
            // 
            this.DataCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.DataCompra.DataPropertyName = "_DataCompra";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "d";
            dataGridViewCellStyle18.NullValue = null;
            this.DataCompra.DefaultCellStyle = dataGridViewCellStyle18;
            this.DataCompra.HeaderText = "Data Compra";
            this.DataCompra.MinimumWidth = 75;
            this.DataCompra.Name = "DataCompra";
            this.DataCompra.ReadOnly = true;
            this.DataCompra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataCompra.Width = 75;
            // 
            // Parts
            // 
            this.Parts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Parts.DataPropertyName = "_Participacions";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N5";
            dataGridViewCellStyle19.NullValue = null;
            this.Parts.DefaultCellStyle = dataGridViewCellStyle19;
            this.Parts.HeaderText = "Parts";
            this.Parts.MinimumWidth = 40;
            this.Parts.Name = "Parts";
            this.Parts.ReadOnly = true;
            this.Parts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Parts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Parts.ToolTipText = "Totes les participacions del moviment. (Poden estar venudes)";
            this.Parts.Width = 40;
            // 
            // PartsDisp
            // 
            this.PartsDisp._NegatiusEnVermell = true;
            this.PartsDisp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.PartsDisp.DataPropertyName = "_PartsDisp";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N5";
            this.PartsDisp.DefaultCellStyle = dataGridViewCellStyle20;
            this.PartsDisp.HeaderText = "Parts Disp.";
            this.PartsDisp.MinimumWidth = 40;
            this.PartsDisp.Name = "PartsDisp";
            this.PartsDisp.ReadOnly = true;
            this.PartsDisp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PartsDisp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PartsDisp.ToolTipText = "Totes les participacions ddisponibles.";
            this.PartsDisp.Width = 40;
            // 
            // PigDeLaCompra
            // 
            this.PigDeLaCompra._NegatiusEnVermell = true;
            this.PigDeLaCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.PigDeLaCompra.DataPropertyName = "_PigDeLaCompra";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "C2";
            dataGridViewCellStyle21.NullValue = null;
            this.PigDeLaCompra.DefaultCellStyle = dataGridViewCellStyle21;
            this.PigDeLaCompra.HeaderText = "PiG";
            this.PigDeLaCompra.MinimumWidth = 30;
            this.PigDeLaCompra.Name = "PigDeLaCompra";
            this.PigDeLaCompra.ReadOnly = true;
            this.PigDeLaCompra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PigDeLaCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PigDeLaCompra.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 2;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 2;
            // 
            // IdOrig
            // 
            this.IdOrig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.IdOrig.DataPropertyName = "_IdOrig";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.NullValue = null;
            this.IdOrig.DefaultCellStyle = dataGridViewCellStyle22;
            this.IdOrig.HeaderText = "Id Orig";
            this.IdOrig.MinimumWidth = 30;
            this.IdOrig.Name = "IdOrig";
            this.IdOrig.ReadOnly = true;
            this.IdOrig.Width = 30;
            // 
            // DataCompraOrig
            // 
            this.DataCompraOrig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.DataCompraOrig.DataPropertyName = "_DataOrig";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Format = "d";
            dataGridViewCellStyle23.NullValue = null;
            this.DataCompraOrig.DefaultCellStyle = dataGridViewCellStyle23;
            this.DataCompraOrig.HeaderText = "Data Orig Compra";
            this.DataCompraOrig.MinimumWidth = 80;
            this.DataCompraOrig.Name = "DataCompraOrig";
            this.DataCompraOrig.ReadOnly = true;
            this.DataCompraOrig.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataCompraOrig.Width = 80;
            // 
            // PigOrigen
            // 
            this.PigOrigen._NegatiusEnVermell = true;
            this.PigOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.PigOrigen.DataPropertyName = "_PigDeLaCompraOrigenTot";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "C2";
            this.PigOrigen.DefaultCellStyle = dataGridViewCellStyle24;
            this.PigOrigen.HeaderText = "Pig Origen";
            this.PigOrigen.MinimumWidth = 60;
            this.PigOrigen.Name = "PigOrigen";
            this.PigOrigen.ReadOnly = true;
            this.PigOrigen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PigOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PigOrigen.Width = 60;
            // 
            // PigOrigenDisponible
            // 
            this.PigOrigenDisponible._NegatiusEnVermell = true;
            this.PigOrigenDisponible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.PigOrigenDisponible.DataPropertyName = "_PigOrigenDisponible";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "C2";
            this.PigOrigenDisponible.DefaultCellStyle = dataGridViewCellStyle25;
            this.PigOrigenDisponible.HeaderText = "Pig Orig. Disp.";
            this.PigOrigenDisponible.MinimumWidth = 60;
            this.PigOrigenDisponible.Name = "PigOrigenDisponible";
            this.PigOrigenDisponible.ReadOnly = true;
            this.PigOrigenDisponible.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PigOrigenDisponible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PigOrigenDisponible.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 2;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 2;
            // 
            // PartsUtil
            // 
            this.PartsUtil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PartsUtil.DataPropertyName = "_ParticipacionsUtilitzades";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N5";
            this.PartsUtil.DefaultCellStyle = dataGridViewCellStyle26;
            this.PartsUtil.HeaderText = "Parts Util";
            this.PartsUtil.MinimumWidth = 60;
            this.PartsUtil.Name = "PartsUtil";
            this.PartsUtil.ReadOnly = true;
            this.PartsUtil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PartsUtil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PartsUtil.ToolTipText = "Participacions utilitzades en la simulació.";
            this.PartsUtil.Width = 60;
            // 
            // PigOrigenUtil
            // 
            this.PigOrigenUtil._NegatiusEnVermell = true;
            this.PigOrigenUtil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.PigOrigenUtil.DataPropertyName = "_PigDeLaCompraPartsUtilOrig";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "C2";
            this.PigOrigenUtil.DefaultCellStyle = dataGridViewCellStyle27;
            this.PigOrigenUtil.HeaderText = "Pig Origen Util";
            this.PigOrigenUtil.MinimumWidth = 50;
            this.PigOrigenUtil.Name = "PigOrigenUtil";
            this.PigOrigenUtil.ReadOnly = true;
            this.PigOrigenUtil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PigOrigenUtil.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 2;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 2;
            // 
            // ValorAct
            // 
            this.ValorAct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ValorAct.DataPropertyName = "_ValorActual";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "C2";
            this.ValorAct.DefaultCellStyle = dataGridViewCellStyle28;
            this.ValorAct.HeaderText = "Valor Act.";
            this.ValorAct.MinimumWidth = 60;
            this.ValorAct.Name = "ValorAct";
            this.ValorAct.ReadOnly = true;
            this.ValorAct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorAct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ValorAct.Width = 60;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btMaxParts);
            this.panel2.Controls.Add(this.btMaxPartsNoTributa);
            this.panel2.Controls.Add(this.lbParcialLliure);
            this.panel2.Controls.Add(this.lbTotPle);
            this.panel2.Controls.Add(this.lbTotLliure);
            this.panel2.Controls.Add(this.groupBox15);
            this.panel2.Controls.Add(this.groupBox10);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox13);
            this.panel2.Controls.Add(this.groupBox11);
            this.panel2.Controls.Add(this.gbPigRealAny);
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Controls.Add(this.groupBox14);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox9);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox12);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btRecalcula);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 241);
            this.panel2.TabIndex = 0;
            // 
            // btMaxParts
            // 
            this.btMaxParts.Enabled = false;
            this.btMaxParts.Location = new System.Drawing.Point(182, 177);
            this.btMaxParts.Margin = new System.Windows.Forms.Padding(0);
            this.btMaxParts.Name = "btMaxParts";
            this.btMaxParts.Size = new System.Drawing.Size(70, 36);
            this.btMaxParts.TabIndex = 20;
            this.btMaxParts.Text = "Max. Parts.";
            this.toolTip1.SetToolTip(this.btMaxParts, "Posa totes les participacions disponibles em: Num. Parts.");
            this.btMaxParts.UseVisualStyleBackColor = true;
            this.btMaxParts.Click += new System.EventHandler(this.btMaxParts_Click);
            // 
            // btMaxPartsNoTributa
            // 
            this.btMaxPartsNoTributa.Enabled = false;
            this.btMaxPartsNoTributa.Location = new System.Drawing.Point(252, 177);
            this.btMaxPartsNoTributa.Margin = new System.Windows.Forms.Padding(0);
            this.btMaxPartsNoTributa.Name = "btMaxPartsNoTributa";
            this.btMaxPartsNoTributa.Size = new System.Drawing.Size(70, 36);
            this.btMaxPartsNoTributa.TabIndex = 20;
            this.btMaxPartsNoTributa.Text = "Max. Parts. No Tributa";
            this.toolTip1.SetToolTip(this.btMaxPartsNoTributa, "Calcula el màxim de participacions que no superin el límit d\'hisenda,");
            this.btMaxPartsNoTributa.UseVisualStyleBackColor = true;
            this.btMaxPartsNoTributa.Click += new System.EventHandler(this.btMaxPartsNoTributa_Click);
            // 
            // lbParcialLliure
            // 
            this.lbParcialLliure.BackColor = System.Drawing.Color.Orange;
            this.lbParcialLliure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbParcialLliure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParcialLliure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbParcialLliure.Location = new System.Drawing.Point(335, 196);
            this.lbParcialLliure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbParcialLliure.Name = "lbParcialLliure";
            this.lbParcialLliure.Size = new System.Drawing.Size(103, 20);
            this.lbParcialLliure.TabIndex = 19;
            this.lbParcialLliure.Text = "Util. parcialment";
            this.lbParcialLliure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotPle
            // 
            this.lbTotPle.BackColor = System.Drawing.Color.Red;
            this.lbTotPle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotPle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotPle.ForeColor = System.Drawing.Color.White;
            this.lbTotPle.Location = new System.Drawing.Point(335, 217);
            this.lbTotPle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotPle.Name = "lbTotPle";
            this.lbTotPle.Size = new System.Drawing.Size(103, 20);
            this.lbTotPle.TabIndex = 18;
            this.lbTotPle.Text = "Utilitzades totes";
            this.lbTotPle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotLliure
            // 
            this.lbTotLliure.BackColor = System.Drawing.Color.Lime;
            this.lbTotLliure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotLliure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotLliure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotLliure.Location = new System.Drawing.Point(335, 177);
            this.lbTotLliure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotLliure.Name = "lbTotLliure";
            this.lbTotLliure.Size = new System.Drawing.Size(103, 20);
            this.lbTotLliure.TabIndex = 17;
            this.lbTotLliure.Text = "No utilitzades";
            this.lbTotLliure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.ntbNumPartsSelect);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(7, 176);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox15.Size = new System.Drawing.Size(90, 38);
            this.groupBox15.TabIndex = 16;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Num Parts Sel";
            this.toolTip1.SetToolTip(this.groupBox15, "Son les participacions de les files seleccionades en la taula.");
            // 
            // ntbNumPartsSelect
            // 
            this.ntbNumPartsSelect._CapturaEscape = true;
            this.ntbNumPartsSelect._Format = "#,##0.#######";
            this.ntbNumPartsSelect._NegatiusEnVermell = false;
            this.ntbNumPartsSelect._PermetDecimals = true;
            this.ntbNumPartsSelect._PermetNegatius = false;
            this.ntbNumPartsSelect._PermetTextNull = false;
            this.ntbNumPartsSelect.BackColor = System.Drawing.SystemColors.Window;
            this.ntbNumPartsSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbNumPartsSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbNumPartsSelect.ForeColor = System.Drawing.Color.Black;
            this.ntbNumPartsSelect.Location = new System.Drawing.Point(2, 12);
            this.ntbNumPartsSelect.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbNumPartsSelect.Name = "ntbNumPartsSelect";
            this.ntbNumPartsSelect.ReadOnly = true;
            this.ntbNumPartsSelect.Size = new System.Drawing.Size(86, 20);
            this.ntbNumPartsSelect.TabIndex = 0;
            this.ntbNumPartsSelect.Text = "0";
            this.ntbNumPartsSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ntbNumPartsSelect, "Son les participacions de les files seleccionades en la taula.");
            this.ntbNumPartsSelect.Valor = new decimal(new int[] {
            0,
            0,
            0,
            262144});
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.ntbDividents);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(336, 92);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox10.Size = new System.Drawing.Size(104, 38);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Dividents";
            // 
            // ntbDividents
            // 
            this.ntbDividents._CapturaEscape = true;
            this.ntbDividents._Format = "#,##0.00 €";
            this.ntbDividents._NegatiusEnVermell = false;
            this.ntbDividents._PermetDecimals = true;
            this.ntbDividents._PermetNegatius = true;
            this.ntbDividents._PermetTextNull = false;
            this.ntbDividents.BackColor = System.Drawing.SystemColors.Window;
            this.ntbDividents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbDividents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbDividents.ForeColor = System.Drawing.Color.Black;
            this.ntbDividents.Location = new System.Drawing.Point(2, 12);
            this.ntbDividents.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbDividents.Name = "ntbDividents";
            this.ntbDividents.ReadOnly = true;
            this.ntbDividents.Size = new System.Drawing.Size(100, 20);
            this.ntbDividents.TabIndex = 0;
            this.ntbDividents.Text = "0,00 €";
            this.ntbDividents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbDividents.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ntbIngressosExterns);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(336, 51);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Size = new System.Drawing.Size(104, 38);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ingressos Externs";
            // 
            // ntbIngressosExterns
            // 
            this.ntbIngressosExterns._CapturaEscape = true;
            this.ntbIngressosExterns._Format = "#,##0.00 €";
            this.ntbIngressosExterns._NegatiusEnVermell = false;
            this.ntbIngressosExterns._PermetDecimals = true;
            this.ntbIngressosExterns._PermetNegatius = true;
            this.ntbIngressosExterns._PermetTextNull = false;
            this.ntbIngressosExterns.BackColor = System.Drawing.SystemColors.Window;
            this.ntbIngressosExterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbIngressosExterns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbIngressosExterns.ForeColor = System.Drawing.Color.Black;
            this.ntbIngressosExterns.Location = new System.Drawing.Point(2, 12);
            this.ntbIngressosExterns.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbIngressosExterns.Name = "ntbIngressosExterns";
            this.ntbIngressosExterns.ReadOnly = true;
            this.ntbIngressosExterns.Size = new System.Drawing.Size(100, 20);
            this.ntbIngressosExterns.TabIndex = 0;
            this.ntbIngressosExterns.Text = "0,00 €";
            this.ntbIngressosExterns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbIngressosExterns.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ntbPerduesAnysAnteriors);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(336, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Size = new System.Drawing.Size(104, 38);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Perdues Anteriors";
            // 
            // ntbPerduesAnysAnteriors
            // 
            this.ntbPerduesAnysAnteriors._CapturaEscape = true;
            this.ntbPerduesAnysAnteriors._Format = "#,##0.00 €";
            this.ntbPerduesAnysAnteriors._NegatiusEnVermell = false;
            this.ntbPerduesAnysAnteriors._PermetDecimals = true;
            this.ntbPerduesAnysAnteriors._PermetNegatius = true;
            this.ntbPerduesAnysAnteriors._PermetTextNull = false;
            this.ntbPerduesAnysAnteriors.BackColor = System.Drawing.SystemColors.Window;
            this.ntbPerduesAnysAnteriors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbPerduesAnysAnteriors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbPerduesAnysAnteriors.ForeColor = System.Drawing.Color.Black;
            this.ntbPerduesAnysAnteriors.Location = new System.Drawing.Point(2, 12);
            this.ntbPerduesAnysAnteriors.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbPerduesAnysAnteriors.Name = "ntbPerduesAnysAnteriors";
            this.ntbPerduesAnysAnteriors.ReadOnly = true;
            this.ntbPerduesAnysAnteriors.Size = new System.Drawing.Size(100, 20);
            this.ntbPerduesAnysAnteriors.TabIndex = 0;
            this.ntbPerduesAnysAnteriors.Text = "0,00 €";
            this.ntbPerduesAnysAnteriors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbPerduesAnysAnteriors.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.ntbPigAltresProductes);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(221, 92);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox13.Size = new System.Drawing.Size(104, 38);
            this.groupBox13.TabIndex = 12;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "PiG D\'altre producte";
            this.toolTip1.SetToolTip(this.groupBox13, "Si vull acumular els PiGs de més d\'un producte, poso aquí limport dels altres.");
            // 
            // ntbPigAltresProductes
            // 
            this.ntbPigAltresProductes._CapturaEscape = true;
            this.ntbPigAltresProductes._Format = "#,##0.00 €";
            this.ntbPigAltresProductes._NegatiusEnVermell = true;
            this.ntbPigAltresProductes._PermetDecimals = true;
            this.ntbPigAltresProductes._PermetNegatius = false;
            this.ntbPigAltresProductes._PermetTextNull = false;
            this.ntbPigAltresProductes.BackColor = System.Drawing.SystemColors.Window;
            this.ntbPigAltresProductes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbPigAltresProductes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbPigAltresProductes.ForeColor = System.Drawing.Color.Black;
            this.ntbPigAltresProductes.Location = new System.Drawing.Point(2, 12);
            this.ntbPigAltresProductes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbPigAltresProductes.Name = "ntbPigAltresProductes";
            this.ntbPigAltresProductes.Size = new System.Drawing.Size(100, 20);
            this.ntbPigAltresProductes.TabIndex = 0;
            this.ntbPigAltresProductes.Text = "0,00 €";
            this.ntbPigAltresProductes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ntbPigAltresProductes, "Si vull acumular els PiGs de més d\'un producte, poso aquí limport dels altres.");
            this.ntbPigAltresProductes.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.ntbTramExentAnual);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(221, 8);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox11.Size = new System.Drawing.Size(104, 38);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Exent Anual";
            this.toolTip1.SetToolTip(this.groupBox11, "És l\'import que no tributa marcat per Hidenda.");
            // 
            // ntbTramExentAnual
            // 
            this.ntbTramExentAnual._CapturaEscape = true;
            this.ntbTramExentAnual._Format = "#,##0.00 €";
            this.ntbTramExentAnual._NegatiusEnVermell = false;
            this.ntbTramExentAnual._PermetDecimals = true;
            this.ntbTramExentAnual._PermetNegatius = false;
            this.ntbTramExentAnual._PermetTextNull = false;
            this.ntbTramExentAnual.BackColor = System.Drawing.SystemColors.Window;
            this.ntbTramExentAnual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbTramExentAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbTramExentAnual.ForeColor = System.Drawing.Color.Black;
            this.ntbTramExentAnual.Location = new System.Drawing.Point(2, 12);
            this.ntbTramExentAnual.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbTramExentAnual.Name = "ntbTramExentAnual";
            this.ntbTramExentAnual.Size = new System.Drawing.Size(100, 20);
            this.ntbTramExentAnual.TabIndex = 0;
            this.ntbTramExentAnual.Text = "0,00 €";
            this.ntbTramExentAnual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ntbTramExentAnual, "És l\'import que no tributa marcat per Hidenda.");
            this.ntbTramExentAnual.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.ntbTramExentAnual.Validating += new System.ComponentModel.CancelEventHandler(this.ntbTramExentAnual_Validating);
            // 
            // gbPigRealAny
            // 
            this.gbPigRealAny.Controls.Add(this.ntbPiGActual);
            this.gbPigRealAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPigRealAny.Location = new System.Drawing.Point(221, 51);
            this.gbPigRealAny.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbPigRealAny.Name = "gbPigRealAny";
            this.gbPigRealAny.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbPigRealAny.Size = new System.Drawing.Size(104, 38);
            this.gbPigRealAny.TabIndex = 10;
            this.gbPigRealAny.TabStop = false;
            this.gbPigRealAny.Text = "PiG Any: ";
            this.toolTip1.SetToolTip(this.gbPigRealAny, "És el PiG de les vendes realitzades en l\'any.");
            // 
            // ntbPiGActual
            // 
            this.ntbPiGActual._CapturaEscape = true;
            this.ntbPiGActual._Format = "#,##0.00 €";
            this.ntbPiGActual._NegatiusEnVermell = true;
            this.ntbPiGActual._PermetDecimals = true;
            this.ntbPiGActual._PermetNegatius = true;
            this.ntbPiGActual._PermetTextNull = false;
            this.ntbPiGActual.BackColor = System.Drawing.SystemColors.Window;
            this.ntbPiGActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbPiGActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbPiGActual.ForeColor = System.Drawing.Color.Black;
            this.ntbPiGActual.Location = new System.Drawing.Point(2, 12);
            this.ntbPiGActual.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbPiGActual.Name = "ntbPiGActual";
            this.ntbPiGActual.ReadOnly = true;
            this.ntbPiGActual.Size = new System.Drawing.Size(100, 20);
            this.ntbPiGActual.TabIndex = 0;
            this.ntbPiGActual.Text = "0,00 €";
            this.ntbPiGActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ntbPiGActual, "És el PiG de les vendes realitzades en l\'any.");
            this.ntbPiGActual.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ntbRestaTramNoTributa);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(221, 135);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox8.Size = new System.Drawing.Size(104, 38);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Exent Restant";
            this.toolTip1.SetToolTip(this.groupBox8, "Import restant de la part exent de tributar.");
            // 
            // ntbRestaTramNoTributa
            // 
            this.ntbRestaTramNoTributa._CapturaEscape = true;
            this.ntbRestaTramNoTributa._Format = "#,##0.00 €";
            this.ntbRestaTramNoTributa._NegatiusEnVermell = false;
            this.ntbRestaTramNoTributa._PermetDecimals = true;
            this.ntbRestaTramNoTributa._PermetNegatius = true;
            this.ntbRestaTramNoTributa._PermetTextNull = false;
            this.ntbRestaTramNoTributa.BackColor = System.Drawing.SystemColors.Window;
            this.ntbRestaTramNoTributa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbRestaTramNoTributa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbRestaTramNoTributa.ForeColor = System.Drawing.Color.Green;
            this.ntbRestaTramNoTributa.Location = new System.Drawing.Point(2, 12);
            this.ntbRestaTramNoTributa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbRestaTramNoTributa.Name = "ntbRestaTramNoTributa";
            this.ntbRestaTramNoTributa.ReadOnly = true;
            this.ntbRestaTramNoTributa.Size = new System.Drawing.Size(100, 20);
            this.ntbRestaTramNoTributa.TabIndex = 0;
            this.ntbRestaTramNoTributa.Text = "0,00 €";
            this.ntbRestaTramNoTributa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ntbRestaTramNoTributa, "Import que no tributa al IRPF. Inclou perdues anys anteriors i dividents.");
            this.ntbRestaTramNoTributa.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.ntbPartsSaltades);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(7, 92);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox14.Size = new System.Drawing.Size(90, 38);
            this.groupBox14.TabIndex = 4;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Parts Saltades";
            this.toolTip1.SetToolTip(this.groupBox14, "Salta les participacions més antigues, fa com si estiguessin venudes.\r\nÉs per no " +
        "haver de fer un traspàs simulat per veure el PiG de les més noves.");
            // 
            // ntbPartsSaltades
            // 
            this.ntbPartsSaltades._CapturaEscape = true;
            this.ntbPartsSaltades._Format = "#,##0.0000";
            this.ntbPartsSaltades._NegatiusEnVermell = false;
            this.ntbPartsSaltades._PermetDecimals = true;
            this.ntbPartsSaltades._PermetNegatius = false;
            this.ntbPartsSaltades._PermetTextNull = false;
            this.ntbPartsSaltades.BackColor = System.Drawing.SystemColors.Window;
            this.ntbPartsSaltades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbPartsSaltades.Enabled = false;
            this.ntbPartsSaltades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbPartsSaltades.ForeColor = System.Drawing.Color.Black;
            this.ntbPartsSaltades.Location = new System.Drawing.Point(2, 12);
            this.ntbPartsSaltades.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbPartsSaltades.Name = "ntbPartsSaltades";
            this.ntbPartsSaltades.Size = new System.Drawing.Size(86, 20);
            this.ntbPartsSaltades.TabIndex = 0;
            this.ntbPartsSaltades.Text = "0,0000";
            this.ntbPartsSaltades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ntbPartsSaltades, "Salta les participacions més antigues, fa com si estiguessin venudes.\r\nÉs per no " +
        "haver de fer un traspàs simulat per veure el PiG de les més noves.");
            this.ntbPartsSaltades.Valor = new decimal(new int[] {
            0,
            0,
            0,
            262144});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ntbNumParticipacions);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(90, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Num, Parts.";
            // 
            // ntbNumParticipacions
            // 
            this.ntbNumParticipacions._CapturaEscape = true;
            this.ntbNumParticipacions._Format = "#,##0.0000";
            this.ntbNumParticipacions._NegatiusEnVermell = false;
            this.ntbNumParticipacions._PermetDecimals = true;
            this.ntbNumParticipacions._PermetNegatius = false;
            this.ntbNumParticipacions._PermetTextNull = false;
            this.ntbNumParticipacions.BackColor = System.Drawing.SystemColors.Window;
            this.ntbNumParticipacions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbNumParticipacions.Enabled = false;
            this.ntbNumParticipacions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbNumParticipacions.ForeColor = System.Drawing.Color.Black;
            this.ntbNumParticipacions.Location = new System.Drawing.Point(2, 12);
            this.ntbNumParticipacions.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbNumParticipacions.Name = "ntbNumParticipacions";
            this.ntbNumParticipacions.Size = new System.Drawing.Size(86, 20);
            this.ntbNumParticipacions.TabIndex = 0;
            this.ntbNumParticipacions.Text = "0,0000";
            this.ntbNumParticipacions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbNumParticipacions.Valor = new decimal(new int[] {
            0,
            0,
            0,
            262144});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ntbPreuParticipacio);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(111, 51);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(90, 38);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preu Partic.";
            // 
            // ntbPreuParticipacio
            // 
            this.ntbPreuParticipacio._CapturaEscape = true;
            this.ntbPreuParticipacio._Format = "#,##0.000 €";
            this.ntbPreuParticipacio._NegatiusEnVermell = false;
            this.ntbPreuParticipacio._PermetDecimals = true;
            this.ntbPreuParticipacio._PermetNegatius = false;
            this.ntbPreuParticipacio._PermetTextNull = false;
            this.ntbPreuParticipacio.BackColor = System.Drawing.SystemColors.Window;
            this.ntbPreuParticipacio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbPreuParticipacio.Enabled = false;
            this.ntbPreuParticipacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbPreuParticipacio.ForeColor = System.Drawing.Color.Black;
            this.ntbPreuParticipacio.Location = new System.Drawing.Point(2, 12);
            this.ntbPreuParticipacio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbPreuParticipacio.Name = "ntbPreuParticipacio";
            this.ntbPreuParticipacio.Size = new System.Drawing.Size(86, 20);
            this.ntbPreuParticipacio.TabIndex = 0;
            this.ntbPreuParticipacio.Text = "0,000 €";
            this.ntbPreuParticipacio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbPreuParticipacio.Valor = new decimal(new int[] {
            0,
            0,
            0,
            196608});
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.ntbTributaRenda);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(336, 135);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox9.Size = new System.Drawing.Size(104, 38);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Tributa Renda";
            this.toolTip1.SetToolTip(this.groupBox9, "Tram exent + Perdues Ant. - PiG Actual - Dividents - PiG Simulació.");
            // 
            // ntbTributaRenda
            // 
            this.ntbTributaRenda._CapturaEscape = true;
            this.ntbTributaRenda._Format = "#,##0.00 €";
            this.ntbTributaRenda._NegatiusEnVermell = false;
            this.ntbTributaRenda._PermetDecimals = true;
            this.ntbTributaRenda._PermetNegatius = true;
            this.ntbTributaRenda._PermetTextNull = false;
            this.ntbTributaRenda.BackColor = System.Drawing.SystemColors.Window;
            this.ntbTributaRenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbTributaRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbTributaRenda.ForeColor = System.Drawing.Color.Red;
            this.ntbTributaRenda.Location = new System.Drawing.Point(2, 12);
            this.ntbTributaRenda.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbTributaRenda.Name = "ntbTributaRenda";
            this.ntbTributaRenda.ReadOnly = true;
            this.ntbTributaRenda.Size = new System.Drawing.Size(100, 20);
            this.ntbTributaRenda.TabIndex = 0;
            this.ntbTributaRenda.Text = "0,00 €";
            this.ntbTributaRenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ntbTributaRenda, "Tram exent + Perdues Ant. - PiG Actual - Dividents - PiG Simulació.");
            this.ntbTributaRenda.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ntbImportBrut);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(111, 92);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox7.Size = new System.Drawing.Size(90, 38);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Import Brut";
            this.toolTip1.SetToolTip(this.groupBox7, "Son les participacions de les files seleccionades en la taula.");
            // 
            // ntbImportBrut
            // 
            this.ntbImportBrut._CapturaEscape = true;
            this.ntbImportBrut._Format = "#,##0.00 €";
            this.ntbImportBrut._NegatiusEnVermell = false;
            this.ntbImportBrut._PermetDecimals = true;
            this.ntbImportBrut._PermetNegatius = true;
            this.ntbImportBrut._PermetTextNull = false;
            this.ntbImportBrut.BackColor = System.Drawing.SystemColors.Window;
            this.ntbImportBrut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbImportBrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbImportBrut.ForeColor = System.Drawing.Color.Black;
            this.ntbImportBrut.Location = new System.Drawing.Point(2, 12);
            this.ntbImportBrut.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbImportBrut.Name = "ntbImportBrut";
            this.ntbImportBrut.ReadOnly = true;
            this.ntbImportBrut.Size = new System.Drawing.Size(86, 20);
            this.ntbImportBrut.TabIndex = 0;
            this.ntbImportBrut.Tag = "";
            this.ntbImportBrut.Text = "0,00 €";
            this.ntbImportBrut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ntbImportBrut, "Son les participacions de les files seleccionades en la taula.");
            this.ntbImportBrut.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbAny);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(7, 8);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox6.Size = new System.Drawing.Size(73, 36);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Any Renda";
            this.toolTip1.SetToolTip(this.groupBox6, "Any Renda");
            // 
            // cbAny
            // 
            this.cbAny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAny.FormattingEnabled = true;
            this.cbAny.Location = new System.Drawing.Point(2, 12);
            this.cbAny.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbAny.Name = "cbAny";
            this.cbAny.Size = new System.Drawing.Size(69, 20);
            this.cbAny.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.ntbPigSimulacio);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(7, 135);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox12.Size = new System.Drawing.Size(90, 38);
            this.groupBox12.TabIndex = 6;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "P i G Prod";
            this.toolTip1.SetToolTip(this.groupBox12, "PiG actual de la simulació.");
            // 
            // ntbPigSimulacio
            // 
            this.ntbPigSimulacio._CapturaEscape = true;
            this.ntbPigSimulacio._Format = "#,##0.00 €";
            this.ntbPigSimulacio._NegatiusEnVermell = true;
            this.ntbPigSimulacio._PermetDecimals = true;
            this.ntbPigSimulacio._PermetNegatius = true;
            this.ntbPigSimulacio._PermetTextNull = false;
            this.ntbPigSimulacio.BackColor = System.Drawing.SystemColors.Window;
            this.ntbPigSimulacio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbPigSimulacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbPigSimulacio.ForeColor = System.Drawing.Color.Black;
            this.ntbPigSimulacio.Location = new System.Drawing.Point(2, 12);
            this.ntbPigSimulacio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbPigSimulacio.Name = "ntbPigSimulacio";
            this.ntbPigSimulacio.ReadOnly = true;
            this.ntbPigSimulacio.Size = new System.Drawing.Size(86, 20);
            this.ntbPigSimulacio.TabIndex = 0;
            this.ntbPigSimulacio.Tag = "";
            this.ntbPigSimulacio.Text = "0,00 €";
            this.ntbPigSimulacio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ntbPigSimulacio, "PiG actual de la simulació.");
            this.ntbPigSimulacio.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ntbPigOrigSimulacio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(111, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(90, 38);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "P i G Orig";
            this.toolTip1.SetToolTip(this.groupBox2, "PiG origen de la simulació.");
            // 
            // ntbPigOrigSimulacio
            // 
            this.ntbPigOrigSimulacio._CapturaEscape = true;
            this.ntbPigOrigSimulacio._Format = "#,##0.00 €";
            this.ntbPigOrigSimulacio._NegatiusEnVermell = true;
            this.ntbPigOrigSimulacio._PermetDecimals = true;
            this.ntbPigOrigSimulacio._PermetNegatius = true;
            this.ntbPigOrigSimulacio._PermetTextNull = false;
            this.ntbPigOrigSimulacio.BackColor = System.Drawing.SystemColors.Window;
            this.ntbPigOrigSimulacio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbPigOrigSimulacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntbPigOrigSimulacio.ForeColor = System.Drawing.Color.Black;
            this.ntbPigOrigSimulacio.Location = new System.Drawing.Point(2, 12);
            this.ntbPigOrigSimulacio.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ntbPigOrigSimulacio.Name = "ntbPigOrigSimulacio";
            this.ntbPigOrigSimulacio.ReadOnly = true;
            this.ntbPigOrigSimulacio.Size = new System.Drawing.Size(86, 20);
            this.ntbPigOrigSimulacio.TabIndex = 0;
            this.ntbPigOrigSimulacio.Tag = "";
            this.ntbPigOrigSimulacio.Text = "0,00 €";
            this.ntbPigOrigSimulacio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ntbPigOrigSimulacio, "PiG origen de la simulació.");
            this.ntbPigOrigSimulacio.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // btRecalcula
            // 
            this.btRecalcula.Location = new System.Drawing.Point(112, 177);
            this.btRecalcula.Margin = new System.Windows.Forms.Padding(0);
            this.btRecalcula.Name = "btRecalcula";
            this.btRecalcula.Size = new System.Drawing.Size(70, 36);
            this.btRecalcula.TabIndex = 1;
            this.btRecalcula.Text = "Recalcula";
            this.btRecalcula.UseVisualStyleBackColor = true;
            this.btRecalcula.Click += new System.EventHandler(this.btRecalcula_Click);
            // 
            // ctrProductes
            // 
            this.ctrProductes._AmbMoviments = true;
            this.ctrProductes._FiltreAnyVisible = false;
            this.ctrProductes._MostraLlistaAmbChecks = false;
            this.ctrProductes._NomesAmbParticipacions = true;
            this.ctrProductes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrProductes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrProductes.Location = new System.Drawing.Point(0, 0);
            this.ctrProductes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ctrProductes.MinimumSize = new System.Drawing.Size(550, 321);
            this.ctrProductes.Name = "ctrProductes";
            this.ctrProductes.Size = new System.Drawing.Size(1025, 321);
            this.ctrProductes.TabIndex = 1;
            this.ctrProductes.EventProducteSeleccionat += new System.EventHandler(this.ctrProductes_EventProducteSeleccionat);
            // 
            // SimulacioVendaTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrProductes);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SimulacioVendaTab";
            this.Size = new System.Drawing.Size(1025, 562);
            this.Load += new System.EventHandler(this.simulacióVendaTab_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompresOriginals)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.gbPigRealAny.ResumeLayout(false);
            this.gbPigRealAny.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GestioProductes ctrProductes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.NumericTextBox2 ntbNumParticipacions;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.NumericTextBox2 ntbPigOrigSimulacio;
        private System.Windows.Forms.GroupBox groupBox3;
        private Controls.NumericTextBox2 ntbPreuParticipacio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btRecalcula;
        private System.Windows.Forms.GroupBox groupBox7;
        private Controls.NumericTextBox2 ntbImportBrut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox8;
        private Controls.NumericTextBox2 ntbRestaTramNoTributa;
        private System.Windows.Forms.GroupBox groupBox9;
        private Controls.NumericTextBox2 ntbTributaRenda;
        private System.Windows.Forms.ComboBox cbAny;
        private System.Windows.Forms.GroupBox groupBox4;
        private Controls.NumericTextBox2 ntbPerduesAnysAnteriors;
        private System.Windows.Forms.GroupBox groupBox5;
        private Controls.NumericTextBox2 ntbIngressosExterns;
        private System.Windows.Forms.GroupBox groupBox10;
        private Controls.NumericTextBox2 ntbDividents;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox gbPigRealAny;
        private Controls.NumericTextBox2 ntbPiGActual;
        private System.Windows.Forms.GroupBox groupBox13;
        private Controls.NumericTextBox2 ntbPigAltresProductes;
        private System.Windows.Forms.GroupBox groupBox12;
        private Controls.NumericTextBox2 ntbPigSimulacio;
        private System.Windows.Forms.GroupBox groupBox14;
        private Controls.NumericTextBox2 ntbPartsSaltades;
        private Controls.NumericTextBox2 ntbTramExentAnual;
        private System.Windows.Forms.GroupBox groupBox15;
        private NumericTextBox2 ntbNumPartsSelect;
        private System.Windows.Forms.Label lbParcialLliure;
        private System.Windows.Forms.Label lbTotPle;
        private System.Windows.Forms.Button btMaxPartsNoTributa;
        private System.Windows.Forms.Button btMaxParts;
        private System.Windows.Forms.Label lbTotLliure;
        private DataGridView3 dgvCompresOriginals;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonsOrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parts;
        private NumericTextBoxColumn2 PartsDisp;
        private NumericTextBoxColumn2 PigDeLaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompraOrig;
        private NumericTextBoxColumn2 PigOrigen;
        private NumericTextBoxColumn2 PigOrigenDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsUtil;
        private NumericTextBoxColumn2 PigOrigenUtil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorAct;
    }
}
