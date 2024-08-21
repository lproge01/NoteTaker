namespace StickyNotes
{
    partial class NoteTaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleBox = new TextBox();
            NoteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PreviousNotes = new DataGridView();
            LoadButton = new Button();
            DeleteButton = new Button();
            NewButton = new Button();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PreviousNotes).BeginInit();
            SuspendLayout();
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(338, 38);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(450, 27);
            TitleBox.TabIndex = 0;
            // 
            // NoteBox
            // 
            NoteBox.Location = new Point(338, 104);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.Size = new Size(450, 334);
            NoteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 7);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 73);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 3;
            label2.Text = "Note:";
            label2.UseWaitCursor = true;
            // 
            // PreviousNotes
            // 
            PreviousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PreviousNotes.BackgroundColor = Color.LightGray;
            PreviousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PreviousNotes.GridColor = SystemColors.ControlText;
            PreviousNotes.Location = new Point(12, 12);
            PreviousNotes.Name = "PreviousNotes";
            PreviousNotes.RowHeadersWidth = 51;
            PreviousNotes.Size = new Size(300, 306);
            PreviousNotes.TabIndex = 4;
            PreviousNotes.CellDoubleClick += PreviousNotes_CellDoubleClick;
            // 
            // LoadButton
            // 
            LoadButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadButton.Location = new Point(12, 384);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(147, 54);
            LoadButton.TabIndex = 5;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(165, 384);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(147, 54);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // NewButton
            // 
            NewButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewButton.Location = new Point(12, 324);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(147, 54);
            NewButton.TabIndex = 7;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(165, 324);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(147, 54);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(SaveButton);
            Controls.Add(NewButton);
            Controls.Add(DeleteButton);
            Controls.Add(LoadButton);
            Controls.Add(PreviousNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NoteBox);
            Controls.Add(TitleBox);
            ForeColor = SystemColors.ControlText;
            Name = "NoteTaker";
            Text = "Note Taker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)PreviousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleBox;
        private TextBox NoteBox;
        private Label label1;
        private Label label2;
        private DataGridView PreviousNotes;
        private Button LoadButton;
        private Button DeleteButton;
        private Button NewButton;
        private Button SaveButton;
    }
}
