namespace Lab3
{
    partial class Interface
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.FuncNameLabel = new System.Windows.Forms.Label();
            this.ParametrALabel = new System.Windows.Forms.Label();
            this.ParametrBLabel = new System.Windows.Forms.Label();
            this.ParametrDLabel = new System.Windows.Forms.Label();
            this.LeftBoardXLabel = new System.Windows.Forms.Label();
            this.ParametrCLabel = new System.Windows.Forms.Label();
            this.ParametrBTextBox = new System.Windows.Forms.TextBox();
            this.ParametrCTextBox = new System.Windows.Forms.TextBox();
            this.ParametrATextBox = new System.Windows.Forms.TextBox();
            this.LeftBoardXTextBox = new System.Windows.Forms.TextBox();
            this.ParametrDTextBox = new System.Windows.Forms.TextBox();
            this.StepXTextBox = new System.Windows.Forms.TextBox();
            this.StepXLabel = new System.Windows.Forms.Label();
            this.RightBoardXTextBox = new System.Windows.Forms.TextBox();
            this.RightBoardXLabel = new System.Windows.Forms.Label();
            this.ResultFuncLabel = new System.Windows.Forms.Label();
            this.LeftBoardXWarningLabel = new System.Windows.Forms.Label();
            this.StepXWarningLabel = new System.Windows.Forms.Label();
            this.RightBoardXWarningLabel = new System.Windows.Forms.Label();
            this.ParametrAWarningLabel = new System.Windows.Forms.Label();
            this.ParametrDWarningLabel = new System.Windows.Forms.Label();
            this.ParametrCWarningLabel = new System.Windows.Forms.Label();
            this.ParametrBWarningLabel = new System.Windows.Forms.Label();
            this.WrongBoardsOrStepWarningLabel = new System.Windows.Forms.Label();
            this.TableOfFunctionValues = new System.Windows.Forms.DataGridView();
            this.FunctionGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelExportBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.WrongBoardsOrStepWarningPicture = new System.Windows.Forms.PictureBox();
            this.ParametrBWarningPicture = new System.Windows.Forms.PictureBox();
            this.ParametrCWarningPicture = new System.Windows.Forms.PictureBox();
            this.ParametrDWarningPicture = new System.Windows.Forms.PictureBox();
            this.ParametrAWarningPicture = new System.Windows.Forms.PictureBox();
            this.RightBoardXWarningPicture = new System.Windows.Forms.PictureBox();
            this.StepXWarningPicture = new System.Windows.Forms.PictureBox();
            this.LeftBoardXWarningPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfFunctionValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionGraph)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WrongBoardsOrStepWarningPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrBWarningPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrCWarningPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrDWarningPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrAWarningPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBoardXWarningPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepXWarningPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBoardXWarningPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncNameLabel
            // 
            this.FuncNameLabel.AutoSize = true;
            this.FuncNameLabel.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Italic);
            this.FuncNameLabel.Location = new System.Drawing.Point(12, 46);
            this.FuncNameLabel.Name = "FuncNameLabel";
            this.FuncNameLabel.Size = new System.Drawing.Size(323, 111);
            this.FuncNameLabel.TabIndex = 8;
            this.FuncNameLabel.Text = "Функция: y = a + b⋅sin(c⋅x + d)";
            // 
            // ParametrALabel
            // 
            this.ParametrALabel.AutoSize = true;
            this.ParametrALabel.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Italic);
            this.ParametrALabel.Location = new System.Drawing.Point(12, 118);
            this.ParametrALabel.Name = "ParametrALabel";
            this.ParametrALabel.Size = new System.Drawing.Size(154, 111);
            this.ParametrALabel.TabIndex = 12;
            this.ParametrALabel.Text = "Параметр a:";
            // 
            // ParametrBLabel
            // 
            this.ParametrBLabel.AutoSize = true;
            this.ParametrBLabel.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Italic);
            this.ParametrBLabel.Location = new System.Drawing.Point(327, 118);
            this.ParametrBLabel.Name = "ParametrBLabel";
            this.ParametrBLabel.Size = new System.Drawing.Size(155, 111);
            this.ParametrBLabel.TabIndex = 13;
            this.ParametrBLabel.Text = "Параметр b:";
            // 
            // ParametrDLabel
            // 
            this.ParametrDLabel.AutoSize = true;
            this.ParametrDLabel.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Italic);
            this.ParametrDLabel.Location = new System.Drawing.Point(327, 219);
            this.ParametrDLabel.Name = "ParametrDLabel";
            this.ParametrDLabel.Size = new System.Drawing.Size(155, 111);
            this.ParametrDLabel.TabIndex = 15;
            this.ParametrDLabel.Text = "Параметр d:";
            // 
            // LeftBoardXLabel
            // 
            this.LeftBoardXLabel.AutoSize = true;
            this.LeftBoardXLabel.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Italic);
            this.LeftBoardXLabel.Location = new System.Drawing.Point(327, 46);
            this.LeftBoardXLabel.Name = "LeftBoardXLabel";
            this.LeftBoardXLabel.Size = new System.Drawing.Size(200, 111);
            this.LeftBoardXLabel.TabIndex = 9;
            this.LeftBoardXLabel.Text = "Левая граница x:";
            // 
            // ParametrCLabel
            // 
            this.ParametrCLabel.AutoSize = true;
            this.ParametrCLabel.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Italic);
            this.ParametrCLabel.Location = new System.Drawing.Point(13, 219);
            this.ParametrCLabel.Name = "ParametrCLabel";
            this.ParametrCLabel.Size = new System.Drawing.Size(153, 111);
            this.ParametrCLabel.TabIndex = 14;
            this.ParametrCLabel.Text = "Параметр c:";
            // 
            // ParametrBTextBox
            // 
            this.ParametrBTextBox.Location = new System.Drawing.Point(488, 161);
            this.ParametrBTextBox.Name = "ParametrBTextBox";
            this.ParametrBTextBox.Size = new System.Drawing.Size(150, 26);
            this.ParametrBTextBox.TabIndex = 5;
            // 
            // ParametrCTextBox
            // 
            this.ParametrCTextBox.Location = new System.Drawing.Point(171, 262);
            this.ParametrCTextBox.Name = "ParametrCTextBox";
            this.ParametrCTextBox.Size = new System.Drawing.Size(150, 26);
            this.ParametrCTextBox.TabIndex = 6;
            // 
            // ParametrATextBox
            // 
            this.ParametrATextBox.Location = new System.Drawing.Point(171, 161);
            this.ParametrATextBox.Name = "ParametrATextBox";
            this.ParametrATextBox.Size = new System.Drawing.Size(150, 26);
            this.ParametrATextBox.TabIndex = 4;
            // 
            // LeftBoardXTextBox
            // 
            this.LeftBoardXTextBox.Location = new System.Drawing.Point(533, 89);
            this.LeftBoardXTextBox.Name = "LeftBoardXTextBox";
            this.LeftBoardXTextBox.Size = new System.Drawing.Size(150, 26);
            this.LeftBoardXTextBox.TabIndex = 1;
            // 
            // ParametrDTextBox
            // 
            this.ParametrDTextBox.Location = new System.Drawing.Point(488, 262);
            this.ParametrDTextBox.Name = "ParametrDTextBox";
            this.ParametrDTextBox.Size = new System.Drawing.Size(150, 26);
            this.ParametrDTextBox.TabIndex = 7;
            // 
            // StepXTextBox
            // 
            this.StepXTextBox.Location = new System.Drawing.Point(801, 89);
            this.StepXTextBox.Name = "StepXTextBox";
            this.StepXTextBox.Size = new System.Drawing.Size(150, 26);
            this.StepXTextBox.TabIndex = 2;
            // 
            // StepXLabel
            // 
            this.StepXLabel.AutoSize = true;
            this.StepXLabel.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Italic);
            this.StepXLabel.Location = new System.Drawing.Point(691, 46);
            this.StepXLabel.Name = "StepXLabel";
            this.StepXLabel.Size = new System.Drawing.Size(104, 111);
            this.StepXLabel.TabIndex = 10;
            this.StepXLabel.Text = "Шаг x:";
            // 
            // RightBoardXTextBox
            // 
            this.RightBoardXTextBox.Location = new System.Drawing.Point(1173, 89);
            this.RightBoardXTextBox.Name = "RightBoardXTextBox";
            this.RightBoardXTextBox.Size = new System.Drawing.Size(150, 26);
            this.RightBoardXTextBox.TabIndex = 3;
            // 
            // RightBoardXLabel
            // 
            this.RightBoardXLabel.AutoSize = true;
            this.RightBoardXLabel.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Italic);
            this.RightBoardXLabel.Location = new System.Drawing.Point(957, 46);
            this.RightBoardXLabel.Name = "RightBoardXLabel";
            this.RightBoardXLabel.Size = new System.Drawing.Size(210, 111);
            this.RightBoardXLabel.TabIndex = 11;
            this.RightBoardXLabel.Text = "Правая граница x:";
            // 
            // ResultFuncLabel
            // 
            this.ResultFuncLabel.AutoSize = true;
            this.ResultFuncLabel.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Italic);
            this.ResultFuncLabel.Location = new System.Drawing.Point(13, 301);
            this.ResultFuncLabel.Name = "ResultFuncLabel";
            this.ResultFuncLabel.Size = new System.Drawing.Size(219, 111);
            this.ResultFuncLabel.TabIndex = 16;
            this.ResultFuncLabel.Text = "y = a + bsin(cx + d)";
            // 
            // LeftBoardXWarningLabel
            // 
            this.LeftBoardXWarningLabel.AutoSize = true;
            this.LeftBoardXWarningLabel.Location = new System.Drawing.Point(533, 61);
            this.LeftBoardXWarningLabel.Name = "LeftBoardXWarningLabel";
            this.LeftBoardXWarningLabel.Size = new System.Drawing.Size(156, 20);
            this.LeftBoardXWarningLabel.TabIndex = 18;
            this.LeftBoardXWarningLabel.Text = "Неверный формат!";
            this.LeftBoardXWarningLabel.Visible = false;
            // 
            // StepXWarningLabel
            // 
            this.StepXWarningLabel.AutoSize = true;
            this.StepXWarningLabel.Location = new System.Drawing.Point(800, 61);
            this.StepXWarningLabel.Name = "StepXWarningLabel";
            this.StepXWarningLabel.Size = new System.Drawing.Size(156, 20);
            this.StepXWarningLabel.TabIndex = 20;
            this.StepXWarningLabel.Text = "Неверный формат!";
            this.StepXWarningLabel.Visible = false;
            // 
            // RightBoardXWarningLabel
            // 
            this.RightBoardXWarningLabel.AutoSize = true;
            this.RightBoardXWarningLabel.Location = new System.Drawing.Point(1173, 61);
            this.RightBoardXWarningLabel.Name = "RightBoardXWarningLabel";
            this.RightBoardXWarningLabel.Size = new System.Drawing.Size(156, 20);
            this.RightBoardXWarningLabel.TabIndex = 22;
            this.RightBoardXWarningLabel.Text = "Неверный формат!";
            this.RightBoardXWarningLabel.Visible = false;
            // 
            // ParametrAWarningLabel
            // 
            this.ParametrAWarningLabel.AutoSize = true;
            this.ParametrAWarningLabel.Location = new System.Drawing.Point(172, 137);
            this.ParametrAWarningLabel.Name = "ParametrAWarningLabel";
            this.ParametrAWarningLabel.Size = new System.Drawing.Size(156, 20);
            this.ParametrAWarningLabel.TabIndex = 24;
            this.ParametrAWarningLabel.Text = "Неверный формат!";
            this.ParametrAWarningLabel.Visible = false;
            // 
            // ParametrDWarningLabel
            // 
            this.ParametrDWarningLabel.AutoSize = true;
            this.ParametrDWarningLabel.Location = new System.Drawing.Point(488, 231);
            this.ParametrDWarningLabel.Name = "ParametrDWarningLabel";
            this.ParametrDWarningLabel.Size = new System.Drawing.Size(156, 20);
            this.ParametrDWarningLabel.TabIndex = 26;
            this.ParametrDWarningLabel.Text = "Неверный формат!";
            this.ParametrDWarningLabel.Visible = false;
            // 
            // ParametrCWarningLabel
            // 
            this.ParametrCWarningLabel.AutoSize = true;
            this.ParametrCWarningLabel.Location = new System.Drawing.Point(172, 231);
            this.ParametrCWarningLabel.Name = "ParametrCWarningLabel";
            this.ParametrCWarningLabel.Size = new System.Drawing.Size(156, 20);
            this.ParametrCWarningLabel.TabIndex = 28;
            this.ParametrCWarningLabel.Text = "Неверный формат!";
            this.ParametrCWarningLabel.Visible = false;
            // 
            // ParametrBWarningLabel
            // 
            this.ParametrBWarningLabel.AutoSize = true;
            this.ParametrBWarningLabel.Location = new System.Drawing.Point(484, 137);
            this.ParametrBWarningLabel.Name = "ParametrBWarningLabel";
            this.ParametrBWarningLabel.Size = new System.Drawing.Size(156, 20);
            this.ParametrBWarningLabel.TabIndex = 30;
            this.ParametrBWarningLabel.Text = "Неверный формат!";
            this.ParametrBWarningLabel.Visible = false;
            // 
            // WrongBoardsOrStepWarningLabel
            // 
            this.WrongBoardsOrStepWarningLabel.AutoSize = true;
            this.WrongBoardsOrStepWarningLabel.Location = new System.Drawing.Point(749, 137);
            this.WrongBoardsOrStepWarningLabel.Name = "WrongBoardsOrStepWarningLabel";
            this.WrongBoardsOrStepWarningLabel.Size = new System.Drawing.Size(0, 20);
            this.WrongBoardsOrStepWarningLabel.TabIndex = 32;
            this.WrongBoardsOrStepWarningLabel.Visible = false;
            // 
            // TableOfFunctionValues
            // 
            this.TableOfFunctionValues.AllowUserToAddRows = false;
            this.TableOfFunctionValues.AllowUserToDeleteRows = false;
            this.TableOfFunctionValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableOfFunctionValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOfFunctionValues.Location = new System.Drawing.Point(27, 415);
            this.TableOfFunctionValues.Name = "TableOfFunctionValues";
            this.TableOfFunctionValues.ReadOnly = true;
            this.TableOfFunctionValues.RowHeadersWidth = 62;
            this.TableOfFunctionValues.RowTemplate.Height = 28;
            this.TableOfFunctionValues.Size = new System.Drawing.Size(613, 154);
            this.TableOfFunctionValues.TabIndex = 33;
            this.TableOfFunctionValues.TabStop = false;
            // 
            // FunctionGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.FunctionGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.FunctionGraph.Legends.Add(legend1);
            this.FunctionGraph.Location = new System.Drawing.Point(650, 163);
            this.FunctionGraph.Name = "FunctionGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "FunctionGraph";
            this.FunctionGraph.Series.Add(series1);
            this.FunctionGraph.Size = new System.Drawing.Size(673, 406);
            this.FunctionGraph.TabIndex = 34;
            this.FunctionGraph.TabStop = false;
            this.FunctionGraph.Text = "chart1";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.About});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1371, 33);
            this.menuStrip.TabIndex = 35;
            this.menuStrip.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcelExportBtn,
            this.ExitProgram});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(69, 29);
            this.File.Text = "Файл";
            // 
            // ExcelExportBtn
            // 
            this.ExcelExportBtn.Enabled = false;
            this.ExcelExportBtn.Name = "ExcelExportBtn";
            this.ExcelExportBtn.Size = new System.Drawing.Size(251, 34);
            this.ExcelExportBtn.Text = "Экспорт в Excel...";
            this.ExcelExportBtn.Click += new System.EventHandler(this.ExcelExportBtn_Click);
            // 
            // ExitProgram
            // 
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(251, 34);
            this.ExitProgram.Text = "Выход";
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // About
            // 
            this.About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgram});
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(97, 29);
            this.About.Text = "Справка";
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(227, 34);
            this.AboutProgram.Text = "О программе";
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "ExcelWorkbook|*.xlsx";
            // 
            // WrongBoardsOrStepWarningPicture
            // 
            this.WrongBoardsOrStepWarningPicture.Image = ((System.Drawing.Image)(resources.GetObject("WrongBoardsOrStepWarningPicture.Image")));
            this.WrongBoardsOrStepWarningPicture.Location = new System.Drawing.Point(710, 125);
            this.WrongBoardsOrStepWarningPicture.Name = "WrongBoardsOrStepWarningPicture";
            this.WrongBoardsOrStepWarningPicture.Size = new System.Drawing.Size(33, 32);
            this.WrongBoardsOrStepWarningPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WrongBoardsOrStepWarningPicture.TabIndex = 31;
            this.WrongBoardsOrStepWarningPicture.TabStop = false;
            this.WrongBoardsOrStepWarningPicture.Visible = false;
            // 
            // ParametrBWarningPicture
            // 
            this.ParametrBWarningPicture.Image = ((System.Drawing.Image)(resources.GetObject("ParametrBWarningPicture.Image")));
            this.ParametrBWarningPicture.Location = new System.Drawing.Point(445, 125);
            this.ParametrBWarningPicture.Name = "ParametrBWarningPicture";
            this.ParametrBWarningPicture.Size = new System.Drawing.Size(33, 32);
            this.ParametrBWarningPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ParametrBWarningPicture.TabIndex = 29;
            this.ParametrBWarningPicture.TabStop = false;
            this.ParametrBWarningPicture.Visible = false;
            // 
            // ParametrCWarningPicture
            // 
            this.ParametrCWarningPicture.Image = ((System.Drawing.Image)(resources.GetObject("ParametrCWarningPicture.Image")));
            this.ParametrCWarningPicture.Location = new System.Drawing.Point(133, 219);
            this.ParametrCWarningPicture.Name = "ParametrCWarningPicture";
            this.ParametrCWarningPicture.Size = new System.Drawing.Size(33, 32);
            this.ParametrCWarningPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ParametrCWarningPicture.TabIndex = 27;
            this.ParametrCWarningPicture.TabStop = false;
            this.ParametrCWarningPicture.Visible = false;
            // 
            // ParametrDWarningPicture
            // 
            this.ParametrDWarningPicture.Image = ((System.Drawing.Image)(resources.GetObject("ParametrDWarningPicture.Image")));
            this.ParametrDWarningPicture.Location = new System.Drawing.Point(449, 219);
            this.ParametrDWarningPicture.Name = "ParametrDWarningPicture";
            this.ParametrDWarningPicture.Size = new System.Drawing.Size(33, 32);
            this.ParametrDWarningPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ParametrDWarningPicture.TabIndex = 25;
            this.ParametrDWarningPicture.TabStop = false;
            this.ParametrDWarningPicture.Visible = false;
            // 
            // ParametrAWarningPicture
            // 
            this.ParametrAWarningPicture.Image = ((System.Drawing.Image)(resources.GetObject("ParametrAWarningPicture.Image")));
            this.ParametrAWarningPicture.Location = new System.Drawing.Point(133, 125);
            this.ParametrAWarningPicture.Name = "ParametrAWarningPicture";
            this.ParametrAWarningPicture.Size = new System.Drawing.Size(33, 32);
            this.ParametrAWarningPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ParametrAWarningPicture.TabIndex = 23;
            this.ParametrAWarningPicture.TabStop = false;
            this.ParametrAWarningPicture.Visible = false;
            // 
            // RightBoardXWarningPicture
            // 
            this.RightBoardXWarningPicture.Image = ((System.Drawing.Image)(resources.GetObject("RightBoardXWarningPicture.Image")));
            this.RightBoardXWarningPicture.Location = new System.Drawing.Point(1134, 49);
            this.RightBoardXWarningPicture.Name = "RightBoardXWarningPicture";
            this.RightBoardXWarningPicture.Size = new System.Drawing.Size(33, 32);
            this.RightBoardXWarningPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightBoardXWarningPicture.TabIndex = 21;
            this.RightBoardXWarningPicture.TabStop = false;
            this.RightBoardXWarningPicture.Visible = false;
            // 
            // StepXWarningPicture
            // 
            this.StepXWarningPicture.Image = ((System.Drawing.Image)(resources.GetObject("StepXWarningPicture.Image")));
            this.StepXWarningPicture.Location = new System.Drawing.Point(762, 50);
            this.StepXWarningPicture.Name = "StepXWarningPicture";
            this.StepXWarningPicture.Size = new System.Drawing.Size(33, 32);
            this.StepXWarningPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StepXWarningPicture.TabIndex = 19;
            this.StepXWarningPicture.TabStop = false;
            this.StepXWarningPicture.Visible = false;
            // 
            // LeftBoardXWarningPicture
            // 
            this.LeftBoardXWarningPicture.Image = ((System.Drawing.Image)(resources.GetObject("LeftBoardXWarningPicture.Image")));
            this.LeftBoardXWarningPicture.Location = new System.Drawing.Point(494, 49);
            this.LeftBoardXWarningPicture.Name = "LeftBoardXWarningPicture";
            this.LeftBoardXWarningPicture.Size = new System.Drawing.Size(33, 32);
            this.LeftBoardXWarningPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftBoardXWarningPicture.TabIndex = 17;
            this.LeftBoardXWarningPicture.TabStop = false;
            this.LeftBoardXWarningPicture.Visible = false;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1371, 590);
            this.Controls.Add(this.FunctionGraph);
            this.Controls.Add(this.TableOfFunctionValues);
            this.Controls.Add(this.WrongBoardsOrStepWarningLabel);
            this.Controls.Add(this.WrongBoardsOrStepWarningPicture);
            this.Controls.Add(this.ParametrBWarningLabel);
            this.Controls.Add(this.ParametrBWarningPicture);
            this.Controls.Add(this.ParametrCWarningLabel);
            this.Controls.Add(this.ParametrCWarningPicture);
            this.Controls.Add(this.ParametrDWarningLabel);
            this.Controls.Add(this.ParametrDWarningPicture);
            this.Controls.Add(this.ParametrAWarningLabel);
            this.Controls.Add(this.ParametrAWarningPicture);
            this.Controls.Add(this.RightBoardXWarningLabel);
            this.Controls.Add(this.RightBoardXWarningPicture);
            this.Controls.Add(this.StepXWarningLabel);
            this.Controls.Add(this.StepXWarningPicture);
            this.Controls.Add(this.LeftBoardXWarningLabel);
            this.Controls.Add(this.LeftBoardXWarningPicture);
            this.Controls.Add(this.ResultFuncLabel);
            this.Controls.Add(this.RightBoardXTextBox);
            this.Controls.Add(this.RightBoardXLabel);
            this.Controls.Add(this.StepXTextBox);
            this.Controls.Add(this.StepXLabel);
            this.Controls.Add(this.ParametrDTextBox);
            this.Controls.Add(this.LeftBoardXTextBox);
            this.Controls.Add(this.ParametrATextBox);
            this.Controls.Add(this.ParametrCTextBox);
            this.Controls.Add(this.ParametrBTextBox);
            this.Controls.Add(this.ParametrCLabel);
            this.Controls.Add(this.LeftBoardXLabel);
            this.Controls.Add(this.ParametrDLabel);
            this.Controls.Add(this.ParametrBLabel);
            this.Controls.Add(this.ParametrALabel);
            this.Controls.Add(this.FuncNameLabel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Interface";
            this.Text = "Синусоида";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveTextBoxesAfterClose);
            ((System.ComponentModel.ISupportInitialize)(this.TableOfFunctionValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionGraph)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WrongBoardsOrStepWarningPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrBWarningPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrCWarningPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrDWarningPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrAWarningPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBoardXWarningPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepXWarningPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBoardXWarningPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FuncNameLabel;
        private System.Windows.Forms.Label ParametrALabel;
        private System.Windows.Forms.Label ParametrBLabel;
        private System.Windows.Forms.Label ParametrDLabel;
        private System.Windows.Forms.Label LeftBoardXLabel;
        private System.Windows.Forms.Label ParametrCLabel;
        private System.Windows.Forms.Label StepXLabel;
        private System.Windows.Forms.Label RightBoardXLabel;
        private System.Windows.Forms.Label ResultFuncLabel;
        private System.Windows.Forms.PictureBox LeftBoardXWarningPicture;
        private System.Windows.Forms.Label LeftBoardXWarningLabel;
        private System.Windows.Forms.Label StepXWarningLabel;
        private System.Windows.Forms.PictureBox StepXWarningPicture;
        private System.Windows.Forms.Label RightBoardXWarningLabel;
        private System.Windows.Forms.PictureBox RightBoardXWarningPicture;
        private System.Windows.Forms.Label ParametrAWarningLabel;
        private System.Windows.Forms.PictureBox ParametrAWarningPicture;
        private System.Windows.Forms.Label ParametrDWarningLabel;
        private System.Windows.Forms.PictureBox ParametrDWarningPicture;
        private System.Windows.Forms.Label ParametrCWarningLabel;
        private System.Windows.Forms.PictureBox ParametrCWarningPicture;
        private System.Windows.Forms.Label ParametrBWarningLabel;
        private System.Windows.Forms.PictureBox ParametrBWarningPicture;
        private System.Windows.Forms.PictureBox WrongBoardsOrStepWarningPicture;
        private System.Windows.Forms.DataGridView TableOfFunctionValues;
        private System.Windows.Forms.DataVisualization.Charting.Chart FunctionGraph;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem ExcelExportBtn;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem ExitProgram;
        public System.Windows.Forms.TextBox ParametrATextBox;
        public System.Windows.Forms.TextBox LeftBoardXTextBox;
        public System.Windows.Forms.TextBox StepXTextBox;
        public System.Windows.Forms.TextBox RightBoardXTextBox;
        private System.Windows.Forms.TextBox ParametrBTextBox;
        private System.Windows.Forms.TextBox ParametrCTextBox;
        private System.Windows.Forms.TextBox ParametrDTextBox;
        public System.Windows.Forms.Label WrongBoardsOrStepWarningLabel;
    }
}