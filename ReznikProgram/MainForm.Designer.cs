namespace ReznikProgram
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.TabControl();
            this.pacient = new System.Windows.Forms.TabPage();
            this.dataGridViewPacient = new System.Windows.Forms.DataGridView();
            this.panelEditPacients = new System.Windows.Forms.Panel();
            this.buttonRemovePacient = new System.Windows.Forms.Button();
            this.buttonAddPacient = new System.Windows.Forms.Button();
            this.buttonPrintPacient = new System.Windows.Forms.Button();
            this.buttonCancelSavePacient = new System.Windows.Forms.Button();
            this.buttonSavePacient = new System.Windows.Forms.Button();
            this.panelSearchPacient = new System.Windows.Forms.Panel();
            this.buttonUntreatedPacient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxToSearchPacient = new System.Windows.Forms.TextBox();
            this.textBoxFromSearchPacient = new System.Windows.Forms.TextBox();
            this.checkBoxDtRegPacient = new System.Windows.Forms.CheckBox();
            this.checkBoxNumberPacient = new System.Windows.Forms.CheckBox();
            this.checkBoxSurnamePacient = new System.Windows.Forms.CheckBox();
            this.textBoxAreaSearchPacient = new System.Windows.Forms.TextBox();
            this.buttonSearchPacient = new System.Windows.Forms.Button();
            this.resultPacient = new System.Windows.Forms.TabPage();
            this.dataGridViewPacientResult = new System.Windows.Forms.DataGridView();
            this.panelEditPacientsResults = new System.Windows.Forms.Panel();
            this.buttonCancelSavePacientResult = new System.Windows.Forms.Button();
            this.buttonSavePacientResult = new System.Windows.Forms.Button();
            this.panelSearchPacientForResult = new System.Windows.Forms.Panel();
            this.checkBoxUntreatedPacient = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSurvey = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInputNumberFrom = new System.Windows.Forms.TextBox();
            this.buttonSearchResultPacient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInputNumberTo = new System.Windows.Forms.TextBox();
            this.surveys = new System.Windows.Forms.TabPage();
            this.dataGridViewSurrey = new System.Windows.Forms.DataGridView();
            this.panelEditSurreis = new System.Windows.Forms.Panel();
            this.buttonShowUntreatedSurrey = new System.Windows.Forms.Button();
            this.buttonCancelSaveSurrey = new System.Windows.Forms.Button();
            this.buttonDeleteSurrey = new System.Windows.Forms.Button();
            this.buttonSaveSurrey = new System.Windows.Forms.Button();
            this.buttonAddSurrey = new System.Windows.Forms.Button();
            this.doctors = new System.Windows.Forms.TabPage();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.panelEditDoctors = new System.Windows.Forms.Panel();
            this.buttonCancelSaveDoctor = new System.Windows.Forms.Button();
            this.buttonDeleteDoctor = new System.Windows.Forms.Button();
            this.buttonSaveDoctor = new System.Windows.Forms.Button();
            this.buttonAddDoctor = new System.Windows.Forms.Button();
            this.units = new System.Windows.Forms.TabPage();
            this.dataGridViewUnit = new System.Windows.Forms.DataGridView();
            this.panelEditUnits = new System.Windows.Forms.Panel();
            this.buttonCancelSaveUnit = new System.Windows.Forms.Button();
            this.buttonDeleteUnit = new System.Windows.Forms.Button();
            this.buttonSaveUnit = new System.Windows.Forms.Button();
            this.buttonAddUnit = new System.Windows.Forms.Button();
            this.tsystem = new System.Windows.Forms.TabPage();
            this.dataGridViewTSystem = new System.Windows.Forms.DataGridView();
            this.panelEditTSystem = new System.Windows.Forms.Panel();
            this.buttonCancelSaveTSystem = new System.Windows.Forms.Button();
            this.buttonDeleteTSystem = new System.Windows.Forms.Button();
            this.buttonSaveTSystem = new System.Windows.Forms.Button();
            this.buttonAddTSystem = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.pacient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacient)).BeginInit();
            this.panelEditPacients.SuspendLayout();
            this.panelSearchPacient.SuspendLayout();
            this.resultPacient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientResult)).BeginInit();
            this.panelEditPacientsResults.SuspendLayout();
            this.panelSearchPacientForResult.SuspendLayout();
            this.surveys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurrey)).BeginInit();
            this.panelEditSurreis.SuspendLayout();
            this.doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.panelEditDoctors.SuspendLayout();
            this.units.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit)).BeginInit();
            this.panelEditUnits.SuspendLayout();
            this.tsystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTSystem)).BeginInit();
            this.panelEditTSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(this.pacient);
            this.mainMenu.Controls.Add(this.resultPacient);
            this.mainMenu.Controls.Add(this.surveys);
            this.mainMenu.Controls.Add(this.doctors);
            this.mainMenu.Controls.Add(this.units);
            this.mainMenu.Controls.Add(this.tsystem);
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.SelectedIndex = 0;
            this.mainMenu.Size = new System.Drawing.Size(1235, 622);
            this.mainMenu.TabIndex = 0;
            // 
            // pacient
            // 
            this.pacient.Controls.Add(this.dataGridViewPacient);
            this.pacient.Controls.Add(this.panelEditPacients);
            this.pacient.Controls.Add(this.panelSearchPacient);
            this.pacient.Location = new System.Drawing.Point(4, 28);
            this.pacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pacient.Name = "pacient";
            this.pacient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pacient.Size = new System.Drawing.Size(1227, 590);
            this.pacient.TabIndex = 0;
            this.pacient.Text = "Пациенты";
            this.pacient.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPacient
            // 
            this.dataGridViewPacient.AllowUserToAddRows = false;
            this.dataGridViewPacient.AllowUserToDeleteRows = false;
            this.dataGridViewPacient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPacient.Location = new System.Drawing.Point(4, 57);
            this.dataGridViewPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPacient.Name = "dataGridViewPacient";
            this.dataGridViewPacient.RowHeadersWidth = 51;
            this.dataGridViewPacient.Size = new System.Drawing.Size(1219, 469);
            this.dataGridViewPacient.TabIndex = 2;
            // 
            // panelEditPacients
            // 
            this.panelEditPacients.Controls.Add(this.buttonRemovePacient);
            this.panelEditPacients.Controls.Add(this.buttonAddPacient);
            this.panelEditPacients.Controls.Add(this.buttonPrintPacient);
            this.panelEditPacients.Controls.Add(this.buttonCancelSavePacient);
            this.panelEditPacients.Controls.Add(this.buttonSavePacient);
            this.panelEditPacients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEditPacients.Location = new System.Drawing.Point(4, 526);
            this.panelEditPacients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEditPacients.Name = "panelEditPacients";
            this.panelEditPacients.Size = new System.Drawing.Size(1219, 60);
            this.panelEditPacients.TabIndex = 1;
            // 
            // buttonRemovePacient
            // 
            this.buttonRemovePacient.Location = new System.Drawing.Point(619, 18);
            this.buttonRemovePacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemovePacient.Name = "buttonRemovePacient";
            this.buttonRemovePacient.Size = new System.Drawing.Size(157, 28);
            this.buttonRemovePacient.TabIndex = 10;
            this.buttonRemovePacient.Text = "Удалить пациента";
            this.buttonRemovePacient.UseVisualStyleBackColor = true;
            // 
            // buttonAddPacient
            // 
            this.buttonAddPacient.Location = new System.Drawing.Point(416, 18);
            this.buttonAddPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddPacient.Name = "buttonAddPacient";
            this.buttonAddPacient.Size = new System.Drawing.Size(183, 28);
            this.buttonAddPacient.TabIndex = 9;
            this.buttonAddPacient.Text = "Добавить пациента";
            this.buttonAddPacient.UseVisualStyleBackColor = true;
            // 
            // buttonPrintPacient
            // 
            this.buttonPrintPacient.Location = new System.Drawing.Point(876, 18);
            this.buttonPrintPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPrintPacient.Name = "buttonPrintPacient";
            this.buttonPrintPacient.Size = new System.Drawing.Size(100, 28);
            this.buttonPrintPacient.TabIndex = 2;
            this.buttonPrintPacient.Text = "Печать";
            this.buttonPrintPacient.UseVisualStyleBackColor = true;
            // 
            // buttonCancelSavePacient
            // 
            this.buttonCancelSavePacient.Location = new System.Drawing.Point(224, 18);
            this.buttonCancelSavePacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelSavePacient.Name = "buttonCancelSavePacient";
            this.buttonCancelSavePacient.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelSavePacient.TabIndex = 1;
            this.buttonCancelSavePacient.Text = "Отмена";
            this.buttonCancelSavePacient.UseVisualStyleBackColor = true;
            // 
            // buttonSavePacient
            // 
            this.buttonSavePacient.Location = new System.Drawing.Point(9, 18);
            this.buttonSavePacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSavePacient.Name = "buttonSavePacient";
            this.buttonSavePacient.Size = new System.Drawing.Size(196, 28);
            this.buttonSavePacient.TabIndex = 0;
            this.buttonSavePacient.Text = "Сохранить изменения";
            this.buttonSavePacient.UseVisualStyleBackColor = true;
            // 
            // panelSearchPacient
            // 
            this.panelSearchPacient.Controls.Add(this.buttonUntreatedPacient);
            this.panelSearchPacient.Controls.Add(this.label5);
            this.panelSearchPacient.Controls.Add(this.label4);
            this.panelSearchPacient.Controls.Add(this.textBoxToSearchPacient);
            this.panelSearchPacient.Controls.Add(this.textBoxFromSearchPacient);
            this.panelSearchPacient.Controls.Add(this.checkBoxDtRegPacient);
            this.panelSearchPacient.Controls.Add(this.checkBoxNumberPacient);
            this.panelSearchPacient.Controls.Add(this.checkBoxSurnamePacient);
            this.panelSearchPacient.Controls.Add(this.textBoxAreaSearchPacient);
            this.panelSearchPacient.Controls.Add(this.buttonSearchPacient);
            this.panelSearchPacient.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchPacient.Location = new System.Drawing.Point(4, 4);
            this.panelSearchPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearchPacient.Name = "panelSearchPacient";
            this.panelSearchPacient.Size = new System.Drawing.Size(1219, 53);
            this.panelSearchPacient.TabIndex = 0;
            // 
            // buttonUntreatedPacient
            // 
            this.buttonUntreatedPacient.Location = new System.Drawing.Point(9, 11);
            this.buttonUntreatedPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUntreatedPacient.Name = "buttonUntreatedPacient";
            this.buttonUntreatedPacient.Size = new System.Drawing.Size(148, 28);
            this.buttonUntreatedPacient.TabIndex = 27;
            this.buttonUntreatedPacient.Text = "Неотработанные";
            this.buttonUntreatedPacient.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "ДО";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "ОТ";
            this.label4.Visible = false;
            // 
            // textBoxToSearchPacient
            // 
            this.textBoxToSearchPacient.Location = new System.Drawing.Point(688, 12);
            this.textBoxToSearchPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxToSearchPacient.Name = "textBoxToSearchPacient";
            this.textBoxToSearchPacient.Size = new System.Drawing.Size(132, 27);
            this.textBoxToSearchPacient.TabIndex = 24;
            this.textBoxToSearchPacient.Visible = false;
            // 
            // textBoxFromSearchPacient
            // 
            this.textBoxFromSearchPacient.Location = new System.Drawing.Point(519, 12);
            this.textBoxFromSearchPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFromSearchPacient.Name = "textBoxFromSearchPacient";
            this.textBoxFromSearchPacient.Size = new System.Drawing.Size(132, 27);
            this.textBoxFromSearchPacient.TabIndex = 23;
            this.textBoxFromSearchPacient.Visible = false;
            // 
            // checkBoxDtRegPacient
            // 
            this.checkBoxDtRegPacient.AutoSize = true;
            this.checkBoxDtRegPacient.Location = new System.Drawing.Point(221, 14);
            this.checkBoxDtRegPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDtRegPacient.Name = "checkBoxDtRegPacient";
            this.checkBoxDtRegPacient.Size = new System.Drawing.Size(66, 25);
            this.checkBoxDtRegPacient.TabIndex = 22;
            this.checkBoxDtRegPacient.Text = "Дата";
            this.checkBoxDtRegPacient.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumberPacient
            // 
            this.checkBoxNumberPacient.AutoSize = true;
            this.checkBoxNumberPacient.Location = new System.Drawing.Point(299, 14);
            this.checkBoxNumberPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxNumberPacient.Name = "checkBoxNumberPacient";
            this.checkBoxNumberPacient.Size = new System.Drawing.Size(81, 25);
            this.checkBoxNumberPacient.TabIndex = 21;
            this.checkBoxNumberPacient.Text = "Номер";
            this.checkBoxNumberPacient.UseVisualStyleBackColor = true;
            // 
            // checkBoxSurnamePacient
            // 
            this.checkBoxSurnamePacient.AutoSize = true;
            this.checkBoxSurnamePacient.Location = new System.Drawing.Point(387, 14);
            this.checkBoxSurnamePacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSurnamePacient.Name = "checkBoxSurnamePacient";
            this.checkBoxSurnamePacient.Size = new System.Drawing.Size(99, 25);
            this.checkBoxSurnamePacient.TabIndex = 20;
            this.checkBoxSurnamePacient.Text = "Фамилия";
            this.checkBoxSurnamePacient.UseVisualStyleBackColor = true;
            // 
            // textBoxAreaSearchPacient
            // 
            this.textBoxAreaSearchPacient.Location = new System.Drawing.Point(495, 11);
            this.textBoxAreaSearchPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAreaSearchPacient.Name = "textBoxAreaSearchPacient";
            this.textBoxAreaSearchPacient.Size = new System.Drawing.Size(325, 27);
            this.textBoxAreaSearchPacient.TabIndex = 19;
            // 
            // buttonSearchPacient
            // 
            this.buttonSearchPacient.Location = new System.Drawing.Point(876, 11);
            this.buttonSearchPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchPacient.Name = "buttonSearchPacient";
            this.buttonSearchPacient.Size = new System.Drawing.Size(100, 28);
            this.buttonSearchPacient.TabIndex = 18;
            this.buttonSearchPacient.Text = "Поиск";
            this.buttonSearchPacient.UseVisualStyleBackColor = true;
            // 
            // resultPacient
            // 
            this.resultPacient.Controls.Add(this.dataGridViewPacientResult);
            this.resultPacient.Controls.Add(this.panelEditPacientsResults);
            this.resultPacient.Controls.Add(this.panelSearchPacientForResult);
            this.resultPacient.Location = new System.Drawing.Point(4, 28);
            this.resultPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultPacient.Name = "resultPacient";
            this.resultPacient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultPacient.Size = new System.Drawing.Size(1227, 590);
            this.resultPacient.TabIndex = 1;
            this.resultPacient.Text = "Результат пациенту";
            this.resultPacient.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPacientResult
            // 
            this.dataGridViewPacientResult.AllowUserToAddRows = false;
            this.dataGridViewPacientResult.AllowUserToDeleteRows = false;
            this.dataGridViewPacientResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPacientResult.Location = new System.Drawing.Point(4, 111);
            this.dataGridViewPacientResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPacientResult.Name = "dataGridViewPacientResult";
            this.dataGridViewPacientResult.RowHeadersWidth = 51;
            this.dataGridViewPacientResult.Size = new System.Drawing.Size(1219, 422);
            this.dataGridViewPacientResult.TabIndex = 3;
            // 
            // panelEditPacientsResults
            // 
            this.panelEditPacientsResults.Controls.Add(this.buttonCancelSavePacientResult);
            this.panelEditPacientsResults.Controls.Add(this.buttonSavePacientResult);
            this.panelEditPacientsResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEditPacientsResults.Location = new System.Drawing.Point(4, 533);
            this.panelEditPacientsResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEditPacientsResults.Name = "panelEditPacientsResults";
            this.panelEditPacientsResults.Size = new System.Drawing.Size(1219, 53);
            this.panelEditPacientsResults.TabIndex = 2;
            // 
            // buttonCancelSavePacientResult
            // 
            this.buttonCancelSavePacientResult.Location = new System.Drawing.Point(224, 12);
            this.buttonCancelSavePacientResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelSavePacientResult.Name = "buttonCancelSavePacientResult";
            this.buttonCancelSavePacientResult.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelSavePacientResult.TabIndex = 3;
            this.buttonCancelSavePacientResult.Text = "Отмена";
            this.buttonCancelSavePacientResult.UseVisualStyleBackColor = true;
            // 
            // buttonSavePacientResult
            // 
            this.buttonSavePacientResult.Location = new System.Drawing.Point(9, 12);
            this.buttonSavePacientResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSavePacientResult.Name = "buttonSavePacientResult";
            this.buttonSavePacientResult.Size = new System.Drawing.Size(196, 28);
            this.buttonSavePacientResult.TabIndex = 2;
            this.buttonSavePacientResult.Text = "Сохранить изменения";
            this.buttonSavePacientResult.UseVisualStyleBackColor = true;
            // 
            // panelSearchPacientForResult
            // 
            this.panelSearchPacientForResult.Controls.Add(this.checkBoxUntreatedPacient);
            this.panelSearchPacientForResult.Controls.Add(this.label6);
            this.panelSearchPacientForResult.Controls.Add(this.comboBoxSurvey);
            this.panelSearchPacientForResult.Controls.Add(this.label3);
            this.panelSearchPacientForResult.Controls.Add(this.textBoxInputNumberFrom);
            this.panelSearchPacientForResult.Controls.Add(this.buttonSearchResultPacient);
            this.panelSearchPacientForResult.Controls.Add(this.label2);
            this.panelSearchPacientForResult.Controls.Add(this.textBoxInputNumberTo);
            this.panelSearchPacientForResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchPacientForResult.Location = new System.Drawing.Point(4, 4);
            this.panelSearchPacientForResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearchPacientForResult.Name = "panelSearchPacientForResult";
            this.panelSearchPacientForResult.Size = new System.Drawing.Size(1219, 107);
            this.panelSearchPacientForResult.TabIndex = 1;
            // 
            // checkBoxUntreatedPacient
            // 
            this.checkBoxUntreatedPacient.AutoSize = true;
            this.checkBoxUntreatedPacient.Location = new System.Drawing.Point(11, 79);
            this.checkBoxUntreatedPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxUntreatedPacient.Name = "checkBoxUntreatedPacient";
            this.checkBoxUntreatedPacient.Size = new System.Drawing.Size(154, 25);
            this.checkBoxUntreatedPacient.TabIndex = 29;
            this.checkBoxUntreatedPacient.Text = "Неотработанные";
            this.checkBoxUntreatedPacient.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Выберите неотработанные анализы по обследованиям";
            // 
            // comboBoxSurvey
            // 
            this.comboBoxSurvey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSurvey.FormattingEnabled = true;
            this.comboBoxSurvey.Location = new System.Drawing.Point(424, 38);
            this.comboBoxSurvey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSurvey.Name = "comboBoxSurvey";
            this.comboBoxSurvey.Size = new System.Drawing.Size(444, 27);
            this.comboBoxSurvey.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Изменение результатов по  номерам пациента\r\n";
            // 
            // textBoxInputNumberFrom
            // 
            this.textBoxInputNumberFrom.Location = new System.Drawing.Point(11, 38);
            this.textBoxInputNumberFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputNumberFrom.Name = "textBoxInputNumberFrom";
            this.textBoxInputNumberFrom.Size = new System.Drawing.Size(132, 27);
            this.textBoxInputNumberFrom.TabIndex = 24;
            // 
            // buttonSearchResultPacient
            // 
            this.buttonSearchResultPacient.Location = new System.Drawing.Point(891, 36);
            this.buttonSearchResultPacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchResultPacient.Name = "buttonSearchResultPacient";
            this.buttonSearchResultPacient.Size = new System.Drawing.Size(108, 31);
            this.buttonSearchResultPacient.TabIndex = 23;
            this.buttonSearchResultPacient.Text = "Поиск";
            this.buttonSearchResultPacient.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "ДО";
            // 
            // textBoxInputNumberTo
            // 
            this.textBoxInputNumberTo.Location = new System.Drawing.Point(207, 38);
            this.textBoxInputNumberTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputNumberTo.Name = "textBoxInputNumberTo";
            this.textBoxInputNumberTo.Size = new System.Drawing.Size(132, 27);
            this.textBoxInputNumberTo.TabIndex = 22;
            // 
            // surveys
            // 
            this.surveys.Controls.Add(this.dataGridViewSurrey);
            this.surveys.Controls.Add(this.panelEditSurreis);
            this.surveys.Location = new System.Drawing.Point(4, 28);
            this.surveys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surveys.Name = "surveys";
            this.surveys.Size = new System.Drawing.Size(1227, 590);
            this.surveys.TabIndex = 2;
            this.surveys.Text = "Обследование";
            this.surveys.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSurrey
            // 
            this.dataGridViewSurrey.AllowUserToAddRows = false;
            this.dataGridViewSurrey.AllowUserToDeleteRows = false;
            this.dataGridViewSurrey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSurrey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSurrey.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSurrey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSurrey.Name = "dataGridViewSurrey";
            this.dataGridViewSurrey.RowHeadersWidth = 51;
            this.dataGridViewSurrey.Size = new System.Drawing.Size(1227, 508);
            this.dataGridViewSurrey.TabIndex = 1;
            // 
            // panelEditSurreis
            // 
            this.panelEditSurreis.Controls.Add(this.buttonShowUntreatedSurrey);
            this.panelEditSurreis.Controls.Add(this.buttonCancelSaveSurrey);
            this.panelEditSurreis.Controls.Add(this.buttonDeleteSurrey);
            this.panelEditSurreis.Controls.Add(this.buttonSaveSurrey);
            this.panelEditSurreis.Controls.Add(this.buttonAddSurrey);
            this.panelEditSurreis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEditSurreis.Location = new System.Drawing.Point(0, 508);
            this.panelEditSurreis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEditSurreis.Name = "panelEditSurreis";
            this.panelEditSurreis.Size = new System.Drawing.Size(1227, 82);
            this.panelEditSurreis.TabIndex = 0;
            // 
            // buttonShowUntreatedSurrey
            // 
            this.buttonShowUntreatedSurrey.Location = new System.Drawing.Point(485, 31);
            this.buttonShowUntreatedSurrey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowUntreatedSurrey.Name = "buttonShowUntreatedSurrey";
            this.buttonShowUntreatedSurrey.Size = new System.Drawing.Size(239, 28);
            this.buttonShowUntreatedSurrey.TabIndex = 23;
            this.buttonShowUntreatedSurrey.Text = "Показать неотработанные";
            this.buttonShowUntreatedSurrey.UseVisualStyleBackColor = true;
            // 
            // buttonCancelSaveSurrey
            // 
            this.buttonCancelSaveSurrey.Location = new System.Drawing.Point(155, 31);
            this.buttonCancelSaveSurrey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelSaveSurrey.Name = "buttonCancelSaveSurrey";
            this.buttonCancelSaveSurrey.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelSaveSurrey.TabIndex = 22;
            this.buttonCancelSaveSurrey.Text = "Отмена";
            this.buttonCancelSaveSurrey.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSurrey
            // 
            this.buttonDeleteSurrey.Location = new System.Drawing.Point(377, 31);
            this.buttonDeleteSurrey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteSurrey.Name = "buttonDeleteSurrey";
            this.buttonDeleteSurrey.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteSurrey.TabIndex = 21;
            this.buttonDeleteSurrey.Text = "Удалить обследование";
            this.buttonDeleteSurrey.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSurrey
            // 
            this.buttonSaveSurrey.Location = new System.Drawing.Point(19, 31);
            this.buttonSaveSurrey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveSurrey.Name = "buttonSaveSurrey";
            this.buttonSaveSurrey.Size = new System.Drawing.Size(128, 28);
            this.buttonSaveSurrey.TabIndex = 20;
            this.buttonSaveSurrey.Text = "Сохранить изменения";
            this.buttonSaveSurrey.UseVisualStyleBackColor = true;
            // 
            // buttonAddSurrey
            // 
            this.buttonAddSurrey.Location = new System.Drawing.Point(263, 31);
            this.buttonAddSurrey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddSurrey.Name = "buttonAddSurrey";
            this.buttonAddSurrey.Size = new System.Drawing.Size(107, 28);
            this.buttonAddSurrey.TabIndex = 19;
            this.buttonAddSurrey.Text = "Добавить обследование";
            this.buttonAddSurrey.UseVisualStyleBackColor = true;
            // 
            // doctors
            // 
            this.doctors.Controls.Add(this.dataGridViewDoctors);
            this.doctors.Controls.Add(this.panelEditDoctors);
            this.doctors.Location = new System.Drawing.Point(4, 28);
            this.doctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctors.Name = "doctors";
            this.doctors.Size = new System.Drawing.Size(1227, 590);
            this.doctors.TabIndex = 3;
            this.doctors.Text = "Врачи";
            this.doctors.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.AllowUserToDeleteRows = false;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDoctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.RowHeadersWidth = 51;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(1227, 500);
            this.dataGridViewDoctors.TabIndex = 1;
            // 
            // panelEditDoctors
            // 
            this.panelEditDoctors.Controls.Add(this.buttonCancelSaveDoctor);
            this.panelEditDoctors.Controls.Add(this.buttonDeleteDoctor);
            this.panelEditDoctors.Controls.Add(this.buttonSaveDoctor);
            this.panelEditDoctors.Controls.Add(this.buttonAddDoctor);
            this.panelEditDoctors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEditDoctors.Location = new System.Drawing.Point(0, 500);
            this.panelEditDoctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEditDoctors.Name = "panelEditDoctors";
            this.panelEditDoctors.Size = new System.Drawing.Size(1227, 90);
            this.panelEditDoctors.TabIndex = 0;
            // 
            // buttonCancelSaveDoctor
            // 
            this.buttonCancelSaveDoctor.Location = new System.Drawing.Point(201, 36);
            this.buttonCancelSaveDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelSaveDoctor.Name = "buttonCancelSaveDoctor";
            this.buttonCancelSaveDoctor.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelSaveDoctor.TabIndex = 20;
            this.buttonCancelSaveDoctor.Text = "Отмена";
            this.buttonCancelSaveDoctor.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDoctor
            // 
            this.buttonDeleteDoctor.Location = new System.Drawing.Point(533, 36);
            this.buttonDeleteDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteDoctor.Name = "buttonDeleteDoctor";
            this.buttonDeleteDoctor.Size = new System.Drawing.Size(157, 28);
            this.buttonDeleteDoctor.TabIndex = 19;
            this.buttonDeleteDoctor.Text = "Удалить врача";
            this.buttonDeleteDoctor.UseVisualStyleBackColor = true;
            // 
            // buttonSaveDoctor
            // 
            this.buttonSaveDoctor.Location = new System.Drawing.Point(11, 36);
            this.buttonSaveDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveDoctor.Name = "buttonSaveDoctor";
            this.buttonSaveDoctor.Size = new System.Drawing.Size(183, 28);
            this.buttonSaveDoctor.TabIndex = 18;
            this.buttonSaveDoctor.Text = "Сохранить изменения";
            this.buttonSaveDoctor.UseVisualStyleBackColor = true;
            // 
            // buttonAddDoctor
            // 
            this.buttonAddDoctor.Location = new System.Drawing.Point(343, 36);
            this.buttonAddDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddDoctor.Name = "buttonAddDoctor";
            this.buttonAddDoctor.Size = new System.Drawing.Size(183, 28);
            this.buttonAddDoctor.TabIndex = 17;
            this.buttonAddDoctor.Text = "Добавить врача";
            this.buttonAddDoctor.UseVisualStyleBackColor = true;
            // 
            // units
            // 
            this.units.Controls.Add(this.dataGridViewUnit);
            this.units.Controls.Add(this.panelEditUnits);
            this.units.Location = new System.Drawing.Point(4, 28);
            this.units.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(1227, 590);
            this.units.TabIndex = 4;
            this.units.Text = "Ед. изм.";
            this.units.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUnit
            // 
            this.dataGridViewUnit.AllowUserToAddRows = false;
            this.dataGridViewUnit.AllowUserToDeleteRows = false;
            this.dataGridViewUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUnit.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewUnit.Name = "dataGridViewUnit";
            this.dataGridViewUnit.RowHeadersWidth = 51;
            this.dataGridViewUnit.Size = new System.Drawing.Size(1227, 500);
            this.dataGridViewUnit.TabIndex = 1;
            // 
            // panelEditUnits
            // 
            this.panelEditUnits.Controls.Add(this.buttonCancelSaveUnit);
            this.panelEditUnits.Controls.Add(this.buttonDeleteUnit);
            this.panelEditUnits.Controls.Add(this.buttonSaveUnit);
            this.panelEditUnits.Controls.Add(this.buttonAddUnit);
            this.panelEditUnits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEditUnits.Location = new System.Drawing.Point(0, 500);
            this.panelEditUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEditUnits.Name = "panelEditUnits";
            this.panelEditUnits.Size = new System.Drawing.Size(1227, 90);
            this.panelEditUnits.TabIndex = 0;
            // 
            // buttonCancelSaveUnit
            // 
            this.buttonCancelSaveUnit.Location = new System.Drawing.Point(209, 32);
            this.buttonCancelSaveUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelSaveUnit.Name = "buttonCancelSaveUnit";
            this.buttonCancelSaveUnit.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelSaveUnit.TabIndex = 20;
            this.buttonCancelSaveUnit.Text = "Отмена";
            this.buttonCancelSaveUnit.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteUnit
            // 
            this.buttonDeleteUnit.Location = new System.Drawing.Point(563, 32);
            this.buttonDeleteUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteUnit.Name = "buttonDeleteUnit";
            this.buttonDeleteUnit.Size = new System.Drawing.Size(157, 28);
            this.buttonDeleteUnit.TabIndex = 19;
            this.buttonDeleteUnit.Text = "Удалить ед.изм.";
            this.buttonDeleteUnit.UseVisualStyleBackColor = true;
            // 
            // buttonSaveUnit
            // 
            this.buttonSaveUnit.Location = new System.Drawing.Point(19, 32);
            this.buttonSaveUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveUnit.Name = "buttonSaveUnit";
            this.buttonSaveUnit.Size = new System.Drawing.Size(183, 28);
            this.buttonSaveUnit.TabIndex = 18;
            this.buttonSaveUnit.Text = "Сохранить изменения";
            this.buttonSaveUnit.UseVisualStyleBackColor = true;
            // 
            // buttonAddUnit
            // 
            this.buttonAddUnit.Location = new System.Drawing.Point(360, 32);
            this.buttonAddUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddUnit.Name = "buttonAddUnit";
            this.buttonAddUnit.Size = new System.Drawing.Size(183, 28);
            this.buttonAddUnit.TabIndex = 17;
            this.buttonAddUnit.Text = "Добавить ед.изм.";
            this.buttonAddUnit.UseVisualStyleBackColor = true;
            // 
            // tsystem
            // 
            this.tsystem.Controls.Add(this.dataGridViewTSystem);
            this.tsystem.Controls.Add(this.panelEditTSystem);
            this.tsystem.Location = new System.Drawing.Point(4, 28);
            this.tsystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tsystem.Name = "tsystem";
            this.tsystem.Size = new System.Drawing.Size(1227, 590);
            this.tsystem.TabIndex = 5;
            this.tsystem.Text = "t-системы";
            this.tsystem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTSystem
            // 
            this.dataGridViewTSystem.AllowUserToAddRows = false;
            this.dataGridViewTSystem.AllowUserToDeleteRows = false;
            this.dataGridViewTSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTSystem.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTSystem.Name = "dataGridViewTSystem";
            this.dataGridViewTSystem.RowHeadersWidth = 51;
            this.dataGridViewTSystem.Size = new System.Drawing.Size(1227, 514);
            this.dataGridViewTSystem.TabIndex = 1;
            // 
            // panelEditTSystem
            // 
            this.panelEditTSystem.Controls.Add(this.buttonCancelSaveTSystem);
            this.panelEditTSystem.Controls.Add(this.buttonDeleteTSystem);
            this.panelEditTSystem.Controls.Add(this.buttonSaveTSystem);
            this.panelEditTSystem.Controls.Add(this.buttonAddTSystem);
            this.panelEditTSystem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEditTSystem.Location = new System.Drawing.Point(0, 514);
            this.panelEditTSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEditTSystem.Name = "panelEditTSystem";
            this.panelEditTSystem.Size = new System.Drawing.Size(1227, 76);
            this.panelEditTSystem.TabIndex = 0;
            // 
            // buttonCancelSaveTSystem
            // 
            this.buttonCancelSaveTSystem.Location = new System.Drawing.Point(216, 27);
            this.buttonCancelSaveTSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelSaveTSystem.Name = "buttonCancelSaveTSystem";
            this.buttonCancelSaveTSystem.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelSaveTSystem.TabIndex = 20;
            this.buttonCancelSaveTSystem.Text = "Отмена";
            this.buttonCancelSaveTSystem.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTSystem
            // 
            this.buttonDeleteTSystem.Location = new System.Drawing.Point(537, 27);
            this.buttonDeleteTSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteTSystem.Name = "buttonDeleteTSystem";
            this.buttonDeleteTSystem.Size = new System.Drawing.Size(157, 28);
            this.buttonDeleteTSystem.TabIndex = 19;
            this.buttonDeleteTSystem.Text = "Удалить t-систему";
            this.buttonDeleteTSystem.UseVisualStyleBackColor = true;
            // 
            // buttonSaveTSystem
            // 
            this.buttonSaveTSystem.Location = new System.Drawing.Point(25, 27);
            this.buttonSaveTSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveTSystem.Name = "buttonSaveTSystem";
            this.buttonSaveTSystem.Size = new System.Drawing.Size(183, 28);
            this.buttonSaveTSystem.TabIndex = 18;
            this.buttonSaveTSystem.Text = "Сохранить изменения";
            this.buttonSaveTSystem.UseVisualStyleBackColor = true;
            // 
            // buttonAddTSystem
            // 
            this.buttonAddTSystem.Location = new System.Drawing.Point(347, 27);
            this.buttonAddTSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTSystem.Name = "buttonAddTSystem";
            this.buttonAddTSystem.Size = new System.Drawing.Size(183, 28);
            this.buttonAddTSystem.TabIndex = 17;
            this.buttonAddTSystem.Text = "Добавить  t-систему";
            this.buttonAddTSystem.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 622);
            this.Controls.Add(this.mainMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Центр Резника";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.pacient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacient)).EndInit();
            this.panelEditPacients.ResumeLayout(false);
            this.panelSearchPacient.ResumeLayout(false);
            this.panelSearchPacient.PerformLayout();
            this.resultPacient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientResult)).EndInit();
            this.panelEditPacientsResults.ResumeLayout(false);
            this.panelSearchPacientForResult.ResumeLayout(false);
            this.panelSearchPacientForResult.PerformLayout();
            this.surveys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurrey)).EndInit();
            this.panelEditSurreis.ResumeLayout(false);
            this.doctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.panelEditDoctors.ResumeLayout(false);
            this.units.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit)).EndInit();
            this.panelEditUnits.ResumeLayout(false);
            this.tsystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTSystem)).EndInit();
            this.panelEditTSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainMenu;
        private System.Windows.Forms.TabPage pacient;
        private System.Windows.Forms.TabPage resultPacient;
        private System.Windows.Forms.TabPage surveys;
        private System.Windows.Forms.TabPage doctors;
        private System.Windows.Forms.TabPage units;
        private System.Windows.Forms.TabPage tsystem;
        private System.Windows.Forms.Panel panelEditPacients;
        private System.Windows.Forms.Button buttonPrintPacient;
        private System.Windows.Forms.Button buttonCancelSavePacient;
        private System.Windows.Forms.Button buttonSavePacient;
        private System.Windows.Forms.DataGridView dataGridViewPacient;
        private System.Windows.Forms.Panel panelSearchPacient;
        private System.Windows.Forms.Button buttonUntreatedPacient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxToSearchPacient;
        private System.Windows.Forms.TextBox textBoxFromSearchPacient;
        private System.Windows.Forms.CheckBox checkBoxDtRegPacient;
        private System.Windows.Forms.CheckBox checkBoxNumberPacient;
        private System.Windows.Forms.CheckBox checkBoxSurnamePacient;
        private System.Windows.Forms.TextBox textBoxAreaSearchPacient;
        private System.Windows.Forms.Button buttonSearchPacient;
        private System.Windows.Forms.Panel panelSearchPacientForResult;
        private System.Windows.Forms.CheckBox checkBoxUntreatedPacient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSurvey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInputNumberFrom;
        private System.Windows.Forms.Button buttonSearchResultPacient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInputNumberTo;
        private System.Windows.Forms.Button buttonRemovePacient;
        private System.Windows.Forms.Button buttonAddPacient;
        private System.Windows.Forms.DataGridView dataGridViewPacientResult;
        private System.Windows.Forms.Panel panelEditPacientsResults;
        private System.Windows.Forms.Button buttonCancelSavePacientResult;
        private System.Windows.Forms.Button buttonSavePacientResult;
        private System.Windows.Forms.DataGridView dataGridViewSurrey;
        private System.Windows.Forms.Panel panelEditSurreis;
        private System.Windows.Forms.Button buttonCancelSaveSurrey;
        private System.Windows.Forms.Button buttonDeleteSurrey;
        private System.Windows.Forms.Button buttonSaveSurrey;
        private System.Windows.Forms.Button buttonAddSurrey;
        private System.Windows.Forms.Button buttonShowUntreatedSurrey;
        private System.Windows.Forms.Panel panelEditDoctors;
        private System.Windows.Forms.DataGridView dataGridViewUnit;
        private System.Windows.Forms.Panel panelEditUnits;
        private System.Windows.Forms.Button buttonCancelSaveUnit;
        private System.Windows.Forms.Button buttonDeleteUnit;
        private System.Windows.Forms.Button buttonSaveUnit;
        private System.Windows.Forms.Button buttonAddUnit;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.Button buttonCancelSaveDoctor;
        private System.Windows.Forms.Button buttonDeleteDoctor;
        private System.Windows.Forms.Button buttonSaveDoctor;
        private System.Windows.Forms.Button buttonAddDoctor;
        private System.Windows.Forms.DataGridView dataGridViewTSystem;
        private System.Windows.Forms.Panel panelEditTSystem;
        private System.Windows.Forms.Button buttonCancelSaveTSystem;
        private System.Windows.Forms.Button buttonDeleteTSystem;
        private System.Windows.Forms.Button buttonSaveTSystem;
        private System.Windows.Forms.Button buttonAddTSystem;
    }
}

