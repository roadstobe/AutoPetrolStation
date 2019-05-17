namespace AZS
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAPS = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelAPS = new System.Windows.Forms.TableLayoutPanel();
            this.labelChoose = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.radioButtonCount = new System.Windows.Forms.RadioButton();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.pricePetrol = new DllForAZS.Price();
            this.comboBoxPetrol = new System.Windows.Forms.ComboBox();
            this.priceAmoung = new DllForAZS.Price();
            this.priceCount = new DllForAZS.Price();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.labelLiter = new System.Windows.Forms.Label();
            this.labelLiters = new System.Windows.Forms.Label();
            this.labelBill = new System.Windows.Forms.Label();
            this.groupBoxCafe = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelCafe = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxBillCafe = new System.Windows.Forms.GroupBox();
            this.labelBillCafe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.HotDocPrice = new DllForAZS.Price();
            this.Gamburger = new DllForAZS.Price();
            this.Potato = new DllForAZS.Price();
            this.CocaCola = new DllForAZS.Price();
            this.priceHotDoc = new DllForAZS.Price();
            this.priceGamburger = new DllForAZS.Price();
            this.pricePotato = new DllForAZS.Price();
            this.priceCocaCola = new DllForAZS.Price();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountHotDog = new DllForAZS.Price();
            this.AnountHambur = new DllForAZS.Price();
            this.AmountPotato = new DllForAZS.Price();
            this.AmountCocaCola = new DllForAZS.Price();
            this.groupBoxSell = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Bill = new DllForAZS.Price();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxBills = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxAPS.SuspendLayout();
            this.tableLayoutPanelAPS.SuspendLayout();
            this.groupBoxPrice.SuspendLayout();
            this.groupBoxCafe.SuspendLayout();
            this.tableLayoutPanelCafe.SuspendLayout();
            this.groupBoxBillCafe.SuspendLayout();
            this.groupBoxSell.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxBills);
            this.splitContainer1.Size = new System.Drawing.Size(860, 318);
            this.splitContainer1.SplitterDistance = 649;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAPS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxCafe, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxSell, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.07547F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.92453F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 318);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxAPS
            // 
            this.groupBoxAPS.Controls.Add(this.tableLayoutPanelAPS);
            this.groupBoxAPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAPS.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAPS.Name = "groupBoxAPS";
            this.groupBoxAPS.Size = new System.Drawing.Size(318, 254);
            this.groupBoxAPS.TabIndex = 0;
            this.groupBoxAPS.TabStop = false;
            this.groupBoxAPS.Text = "Автозаправка";
            // 
            // tableLayoutPanelAPS
            // 
            this.tableLayoutPanelAPS.ColumnCount = 2;
            this.tableLayoutPanelAPS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.84064F));
            this.tableLayoutPanelAPS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.15936F));
            this.tableLayoutPanelAPS.Controls.Add(this.labelChoose, 0, 0);
            this.tableLayoutPanelAPS.Controls.Add(this.labelPrice, 0, 1);
            this.tableLayoutPanelAPS.Controls.Add(this.radioButtonCount, 0, 2);
            this.tableLayoutPanelAPS.Controls.Add(this.radioButtonPrice, 0, 3);
            this.tableLayoutPanelAPS.Controls.Add(this.pricePetrol, 1, 1);
            this.tableLayoutPanelAPS.Controls.Add(this.comboBoxPetrol, 1, 0);
            this.tableLayoutPanelAPS.Controls.Add(this.priceAmoung, 1, 3);
            this.tableLayoutPanelAPS.Controls.Add(this.priceCount, 1, 2);
            this.tableLayoutPanelAPS.Controls.Add(this.groupBoxPrice, 0, 4);
            this.tableLayoutPanelAPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAPS.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelAPS.Name = "tableLayoutPanelAPS";
            this.tableLayoutPanelAPS.RowCount = 5;
            this.tableLayoutPanelAPS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.6535F));
            this.tableLayoutPanelAPS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.6535F));
            this.tableLayoutPanelAPS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.6535F));
            this.tableLayoutPanelAPS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.59575F));
            this.tableLayoutPanelAPS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.68085F));
            this.tableLayoutPanelAPS.Size = new System.Drawing.Size(312, 235);
            this.tableLayoutPanelAPS.TabIndex = 0;
            // 
            // labelChoose
            // 
            this.labelChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoose.Location = new System.Drawing.Point(3, 13);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(118, 20);
            this.labelChoose.TabIndex = 0;
            this.labelChoose.Text = "Бензин";
            this.labelChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(3, 59);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(118, 20);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Ціна";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonCount
            // 
            this.radioButtonCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCount.AutoSize = true;
            this.radioButtonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCount.Location = new System.Drawing.Point(37, 95);
            this.radioButtonCount.Name = "radioButtonCount";
            this.radioButtonCount.Size = new System.Drawing.Size(84, 21);
            this.radioButtonCount.TabIndex = 2;
            this.radioButtonCount.Text = "Кількість";
            this.radioButtonCount.UseVisualStyleBackColor = true;
            this.radioButtonCount.CheckedChanged += new System.EventHandler(this.RadioButtonCount_CheckedChanged);
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPrice.Location = new System.Drawing.Point(38, 141);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(83, 21);
            this.radioButtonPrice.TabIndex = 3;
            this.radioButtonPrice.Text = "Сума      ";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            // 
            // pricePetrol
            // 
            this.pricePetrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pricePetrol.CountDot = 2;
            this.pricePetrol.Enabled = false;
            this.pricePetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricePetrol.Location = new System.Drawing.Point(127, 57);
            this.pricePetrol.Name = "pricePetrol";
            this.pricePetrol.Size = new System.Drawing.Size(182, 23);
            this.pricePetrol.TabIndex = 5;
            // 
            // comboBoxPetrol
            // 
            this.comboBoxPetrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPetrol.FormattingEnabled = true;
            this.comboBoxPetrol.Location = new System.Drawing.Point(127, 10);
            this.comboBoxPetrol.Name = "comboBoxPetrol";
            this.comboBoxPetrol.Size = new System.Drawing.Size(182, 24);
            this.comboBoxPetrol.Sorted = true;
            this.comboBoxPetrol.TabIndex = 6;
            this.comboBoxPetrol.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPetrol_SelectedIndexChanged);
            // 
            // priceAmoung
            // 
            this.priceAmoung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.priceAmoung.CountDot = 2;
            this.priceAmoung.Enabled = false;
            this.priceAmoung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceAmoung.Location = new System.Drawing.Point(168, 141);
            this.priceAmoung.Name = "priceAmoung";
            this.priceAmoung.Size = new System.Drawing.Size(100, 23);
            this.priceAmoung.TabIndex = 8;
            this.priceAmoung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceAmoung.TextChanged += new System.EventHandler(this.PriceAmoung_TextChanged);
            // 
            // priceCount
            // 
            this.priceCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.priceCount.CountDot = 3;
            this.priceCount.Enabled = false;
            this.priceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCount.Location = new System.Drawing.Point(168, 95);
            this.priceCount.Name = "priceCount";
            this.priceCount.Size = new System.Drawing.Size(100, 23);
            this.priceCount.TabIndex = 7;
            this.priceCount.TextChanged += new System.EventHandler(this.PriceCount_TextChanged);
            // 
            // groupBoxPrice
            // 
            this.tableLayoutPanelAPS.SetColumnSpan(this.groupBoxPrice, 2);
            this.groupBoxPrice.Controls.Add(this.labelLiter);
            this.groupBoxPrice.Controls.Add(this.labelLiters);
            this.groupBoxPrice.Controls.Add(this.labelBill);
            this.groupBoxPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPrice.Location = new System.Drawing.Point(3, 179);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Size = new System.Drawing.Size(306, 53);
            this.groupBoxPrice.TabIndex = 4;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "До сплати";
            // 
            // labelLiter
            // 
            this.labelLiter.AutoSize = true;
            this.labelLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLiter.Location = new System.Drawing.Point(7, 16);
            this.labelLiter.Name = "labelLiter";
            this.labelLiter.Size = new System.Drawing.Size(0, 20);
            this.labelLiter.TabIndex = 2;
            // 
            // labelLiters
            // 
            this.labelLiters.AutoSize = true;
            this.labelLiters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLiters.Location = new System.Drawing.Point(73, 16);
            this.labelLiters.Name = "labelLiters";
            this.labelLiters.Size = new System.Drawing.Size(0, 20);
            this.labelLiters.TabIndex = 1;
            // 
            // labelBill
            // 
            this.labelBill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBill.AutoSize = true;
            this.labelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBill.Location = new System.Drawing.Point(196, 17);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(20, 24);
            this.labelBill.TabIndex = 0;
            this.labelBill.Text = "0";
            this.labelBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBill.TextChanged += new System.EventHandler(this.LabelBill_TextChanged);
            // 
            // groupBoxCafe
            // 
            this.groupBoxCafe.Controls.Add(this.tableLayoutPanelCafe);
            this.groupBoxCafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCafe.Location = new System.Drawing.Point(327, 3);
            this.groupBoxCafe.Name = "groupBoxCafe";
            this.groupBoxCafe.Size = new System.Drawing.Size(319, 254);
            this.groupBoxCafe.TabIndex = 1;
            this.groupBoxCafe.TabStop = false;
            this.groupBoxCafe.Text = "Міні-Кафе ";
            // 
            // tableLayoutPanelCafe
            // 
            this.tableLayoutPanelCafe.ColumnCount = 4;
            this.tableLayoutPanelCafe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.90735F));
            this.tableLayoutPanelCafe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.16933F));
            this.tableLayoutPanelCafe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.32268F));
            this.tableLayoutPanelCafe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.96166F));
            this.tableLayoutPanelCafe.Controls.Add(this.groupBoxBillCafe, 0, 5);
            this.tableLayoutPanelCafe.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanelCafe.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelCafe.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanelCafe.Controls.Add(this.checkBox2, 0, 2);
            this.tableLayoutPanelCafe.Controls.Add(this.checkBox3, 0, 3);
            this.tableLayoutPanelCafe.Controls.Add(this.checkBox4, 0, 4);
            this.tableLayoutPanelCafe.Controls.Add(this.HotDocPrice, 1, 1);
            this.tableLayoutPanelCafe.Controls.Add(this.Gamburger, 1, 2);
            this.tableLayoutPanelCafe.Controls.Add(this.Potato, 1, 3);
            this.tableLayoutPanelCafe.Controls.Add(this.CocaCola, 1, 4);
            this.tableLayoutPanelCafe.Controls.Add(this.priceHotDoc, 2, 1);
            this.tableLayoutPanelCafe.Controls.Add(this.priceGamburger, 2, 2);
            this.tableLayoutPanelCafe.Controls.Add(this.pricePotato, 2, 3);
            this.tableLayoutPanelCafe.Controls.Add(this.priceCocaCola, 2, 4);
            this.tableLayoutPanelCafe.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanelCafe.Controls.Add(this.AmountHotDog, 3, 1);
            this.tableLayoutPanelCafe.Controls.Add(this.AnountHambur, 3, 2);
            this.tableLayoutPanelCafe.Controls.Add(this.AmountPotato, 3, 3);
            this.tableLayoutPanelCafe.Controls.Add(this.AmountCocaCola, 3, 4);
            this.tableLayoutPanelCafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCafe.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelCafe.Name = "tableLayoutPanelCafe";
            this.tableLayoutPanelCafe.RowCount = 6;
            this.tableLayoutPanelCafe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27545F));
            this.tableLayoutPanelCafe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27544F));
            this.tableLayoutPanelCafe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27544F));
            this.tableLayoutPanelCafe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27544F));
            this.tableLayoutPanelCafe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27544F));
            this.tableLayoutPanelCafe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.62278F));
            this.tableLayoutPanelCafe.Size = new System.Drawing.Size(313, 235);
            this.tableLayoutPanelCafe.TabIndex = 0;
            // 
            // groupBoxBillCafe
            // 
            this.tableLayoutPanelCafe.SetColumnSpan(this.groupBoxBillCafe, 4);
            this.groupBoxBillCafe.Controls.Add(this.labelBillCafe);
            this.groupBoxBillCafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBillCafe.Location = new System.Drawing.Point(3, 178);
            this.groupBoxBillCafe.Name = "groupBoxBillCafe";
            this.groupBoxBillCafe.Size = new System.Drawing.Size(307, 54);
            this.groupBoxBillCafe.TabIndex = 0;
            this.groupBoxBillCafe.TabStop = false;
            this.groupBoxBillCafe.Text = "До сплати";
            // 
            // labelBillCafe
            // 
            this.labelBillCafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBillCafe.AutoSize = true;
            this.labelBillCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBillCafe.Location = new System.Drawing.Point(150, 26);
            this.labelBillCafe.Name = "labelBillCafe";
            this.labelBillCafe.Size = new System.Drawing.Size(19, 20);
            this.labelBillCafe.TabIndex = 0;
            this.labelBillCafe.Text = "0";
            this.labelBillCafe.TextChanged += new System.EventHandler(this.LabelBill_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(166, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ціна";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(3, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Хот-Дог";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(3, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 29);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Гамбургер";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(3, 108);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 29);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Картопля фрі";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4.Location = new System.Drawing.Point(3, 143);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(97, 29);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Кока кола ";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // HotDocPrice
            // 
            this.HotDocPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HotDocPrice.CountDot = 2;
            this.HotDocPrice.Enabled = false;
            this.HotDocPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotDocPrice.Location = new System.Drawing.Point(106, 41);
            this.HotDocPrice.Name = "HotDocPrice";
            this.HotDocPrice.Size = new System.Drawing.Size(54, 23);
            this.HotDocPrice.TabIndex = 16;
            this.HotDocPrice.Text = "16";
            this.HotDocPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gamburger
            // 
            this.Gamburger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Gamburger.CountDot = 2;
            this.Gamburger.Enabled = false;
            this.Gamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gamburger.Location = new System.Drawing.Point(106, 76);
            this.Gamburger.Name = "Gamburger";
            this.Gamburger.Size = new System.Drawing.Size(54, 23);
            this.Gamburger.TabIndex = 17;
            this.Gamburger.Text = "27,96";
            this.Gamburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Potato
            // 
            this.Potato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Potato.CountDot = 2;
            this.Potato.Enabled = false;
            this.Potato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Potato.Location = new System.Drawing.Point(106, 111);
            this.Potato.Name = "Potato";
            this.Potato.Size = new System.Drawing.Size(54, 23);
            this.Potato.TabIndex = 18;
            this.Potato.Text = "14,78";
            this.Potato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CocaCola
            // 
            this.CocaCola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CocaCola.CountDot = 2;
            this.CocaCola.Enabled = false;
            this.CocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CocaCola.Location = new System.Drawing.Point(106, 146);
            this.CocaCola.Name = "CocaCola";
            this.CocaCola.Size = new System.Drawing.Size(54, 23);
            this.CocaCola.TabIndex = 19;
            this.CocaCola.Text = "7,96";
            this.CocaCola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceHotDoc
            // 
            this.priceHotDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceHotDoc.CountDot = 0;
            this.priceHotDoc.Enabled = false;
            this.priceHotDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceHotDoc.Location = new System.Drawing.Point(166, 41);
            this.priceHotDoc.Name = "priceHotDoc";
            this.priceHotDoc.Size = new System.Drawing.Size(67, 23);
            this.priceHotDoc.TabIndex = 20;
            this.priceHotDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceHotDoc.TextChanged += new System.EventHandler(this.PriceHotDoc_TextChanged);
            // 
            // priceGamburger
            // 
            this.priceGamburger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceGamburger.CountDot = 0;
            this.priceGamburger.Enabled = false;
            this.priceGamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceGamburger.Location = new System.Drawing.Point(166, 76);
            this.priceGamburger.Name = "priceGamburger";
            this.priceGamburger.Size = new System.Drawing.Size(67, 23);
            this.priceGamburger.TabIndex = 21;
            this.priceGamburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceGamburger.TextChanged += new System.EventHandler(this.PriceGamburger_TextChanged);
            // 
            // pricePotato
            // 
            this.pricePotato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pricePotato.CountDot = 0;
            this.pricePotato.Enabled = false;
            this.pricePotato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pricePotato.Location = new System.Drawing.Point(166, 111);
            this.pricePotato.Name = "pricePotato";
            this.pricePotato.Size = new System.Drawing.Size(67, 23);
            this.pricePotato.TabIndex = 22;
            this.pricePotato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pricePotato.TextChanged += new System.EventHandler(this.PricePotato_TextChanged);
            // 
            // priceCocaCola
            // 
            this.priceCocaCola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceCocaCola.CountDot = 0;
            this.priceCocaCola.Enabled = false;
            this.priceCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCocaCola.Location = new System.Drawing.Point(166, 146);
            this.priceCocaCola.Name = "priceCocaCola";
            this.priceCocaCola.Size = new System.Drawing.Size(67, 23);
            this.priceCocaCola.TabIndex = 23;
            this.priceCocaCola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceCocaCola.TextChanged += new System.EventHandler(this.PriceCocaCola_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(239, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 35);
            this.label3.TabIndex = 24;
            this.label3.Text = "Загалом";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountHotDog
            // 
            this.AmountHotDog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountHotDog.CountDot = 2;
            this.AmountHotDog.Enabled = false;
            this.AmountHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountHotDog.Location = new System.Drawing.Point(239, 41);
            this.AmountHotDog.Name = "AmountHotDog";
            this.AmountHotDog.Size = new System.Drawing.Size(71, 23);
            this.AmountHotDog.TabIndex = 25;
            this.AmountHotDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountHotDog.TextChanged += new System.EventHandler(this.Amount);
            // 
            // AnountHambur
            // 
            this.AnountHambur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AnountHambur.CountDot = 0;
            this.AnountHambur.Enabled = false;
            this.AnountHambur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnountHambur.Location = new System.Drawing.Point(239, 76);
            this.AnountHambur.Name = "AnountHambur";
            this.AnountHambur.Size = new System.Drawing.Size(71, 23);
            this.AnountHambur.TabIndex = 26;
            this.AnountHambur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AnountHambur.TextChanged += new System.EventHandler(this.Amount);
            // 
            // AmountPotato
            // 
            this.AmountPotato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountPotato.CountDot = 0;
            this.AmountPotato.Enabled = false;
            this.AmountPotato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountPotato.Location = new System.Drawing.Point(239, 111);
            this.AmountPotato.Name = "AmountPotato";
            this.AmountPotato.Size = new System.Drawing.Size(71, 23);
            this.AmountPotato.TabIndex = 27;
            this.AmountPotato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountPotato.TextChanged += new System.EventHandler(this.Amount);
            // 
            // AmountCocaCola
            // 
            this.AmountCocaCola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountCocaCola.CountDot = 0;
            this.AmountCocaCola.Enabled = false;
            this.AmountCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountCocaCola.Location = new System.Drawing.Point(239, 146);
            this.AmountCocaCola.Name = "AmountCocaCola";
            this.AmountCocaCola.Size = new System.Drawing.Size(71, 23);
            this.AmountCocaCola.TabIndex = 28;
            this.AmountCocaCola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountCocaCola.TextChanged += new System.EventHandler(this.Amount);
            // 
            // groupBoxSell
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxSell, 2);
            this.groupBoxSell.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSell.Location = new System.Drawing.Point(3, 263);
            this.groupBoxSell.Name = "groupBoxSell";
            this.groupBoxSell.Size = new System.Drawing.Size(643, 52);
            this.groupBoxSell.TabIndex = 3;
            this.groupBoxSell.TabStop = false;
            this.groupBoxSell.Text = "Всього до оплати";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Bill, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(637, 33);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Bill
            // 
            this.Bill.CountDot = 2;
            this.Bill.Dock = System.Windows.Forms.DockStyle.Right;
            this.Bill.Enabled = false;
            this.Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bill.Location = new System.Drawing.Point(475, 3);
            this.Bill.Multiline = true;
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(159, 27);
            this.Bill.TabIndex = 4;
            this.Bill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(215, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Порахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBoxBills
            // 
            this.listBoxBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxBills.FormattingEnabled = true;
            this.listBoxBills.ItemHeight = 16;
            this.listBoxBills.Location = new System.Drawing.Point(0, 0);
            this.listBoxBills.Name = "listBoxBills";
            this.listBoxBills.Size = new System.Drawing.Size(207, 318);
            this.listBoxBills.TabIndex = 0;
            this.listBoxBills.SelectedIndexChanged += new System.EventHandler(this.ListBoxBills_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 318);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(876, 357);
            this.Name = "MainForm";
            this.Text = "BestOil";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxAPS.ResumeLayout(false);
            this.tableLayoutPanelAPS.ResumeLayout(false);
            this.tableLayoutPanelAPS.PerformLayout();
            this.groupBoxPrice.ResumeLayout(false);
            this.groupBoxPrice.PerformLayout();
            this.groupBoxCafe.ResumeLayout(false);
            this.tableLayoutPanelCafe.ResumeLayout(false);
            this.tableLayoutPanelCafe.PerformLayout();
            this.groupBoxBillCafe.ResumeLayout(false);
            this.groupBoxBillCafe.PerformLayout();
            this.groupBoxSell.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxAPS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAPS;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.RadioButton radioButtonCount;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.GroupBox groupBoxPrice;
        private System.Windows.Forms.Label labelBill;
        private DllForAZS.Price pricePetrol;
        private System.Windows.Forms.ComboBox comboBoxPetrol;
        private DllForAZS.Price priceCount;
        private DllForAZS.Price priceAmoung;
        private System.Windows.Forms.Label labelLiters;
        private System.Windows.Forms.Label labelLiter;
        private System.Windows.Forms.GroupBox groupBoxCafe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCafe;
        private System.Windows.Forms.GroupBox groupBoxBillCafe;
        private System.Windows.Forms.Label labelBillCafe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private DllForAZS.Price HotDocPrice;
        private DllForAZS.Price Gamburger;
        private DllForAZS.Price Potato;
        private DllForAZS.Price CocaCola;
        private DllForAZS.Price priceHotDoc;
        private DllForAZS.Price priceGamburger;
        private DllForAZS.Price pricePotato;
        private DllForAZS.Price priceCocaCola;
        private System.Windows.Forms.Label label3;
        private DllForAZS.Price AmountHotDog;
        private DllForAZS.Price AnountHambur;
        private DllForAZS.Price AmountPotato;
        private DllForAZS.Price AmountCocaCola;
        private System.Windows.Forms.GroupBox groupBoxSell;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DllForAZS.Price Bill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxBills;
    }
}

