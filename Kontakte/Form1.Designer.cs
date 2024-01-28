namespace Kontakte
{
    partial class Adressliste
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label kontaktIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label strasseLabel;
            System.Windows.Forms.Label pLZLabel;
            System.Windows.Forms.Label ortLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adressliste));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kontakteDatabaseDataSet = new Kontakte.KontakteDatabaseDataSet();
            this.personenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personenTableAdapter = new Kontakte.KontakteDatabaseDataSetTableAdapters.PersonenTableAdapter();
            this.tableAdapterManager = new Kontakte.KontakteDatabaseDataSetTableAdapters.TableAdapterManager();
            this.personenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kontaktIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.strasseTextBox = new System.Windows.Forms.TextBox();
            this.pLZTextBox = new System.Windows.Forms.TextBox();
            this.ortTextBox = new System.Windows.Forms.TextBox();
            kontaktIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            strasseLabel = new System.Windows.Forms.Label();
            pLZLabel = new System.Windows.Forms.Label();
            ortLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingNavigator)).BeginInit();
            this.personenBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kontaktIDLabel
            // 
            kontaktIDLabel.AutoSize = true;
            kontaktIDLabel.Location = new System.Drawing.Point(12, 43);
            kontaktIDLabel.Name = "kontaktIDLabel";
            kontaktIDLabel.Size = new System.Drawing.Size(61, 13);
            kontaktIDLabel.TabIndex = 2;
            kontaktIDLabel.Text = "Kontakt ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 69);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(12, 95);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 6;
            telefonLabel.Text = "Telefon:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 121);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // strasseLabel
            // 
            strasseLabel.AutoSize = true;
            strasseLabel.Location = new System.Drawing.Point(12, 147);
            strasseLabel.Name = "strasseLabel";
            strasseLabel.Size = new System.Drawing.Size(45, 13);
            strasseLabel.TabIndex = 10;
            strasseLabel.Text = "Strasse:";
            // 
            // pLZLabel
            // 
            pLZLabel.AutoSize = true;
            pLZLabel.Location = new System.Drawing.Point(12, 173);
            pLZLabel.Name = "pLZLabel";
            pLZLabel.Size = new System.Drawing.Size(30, 13);
            pLZLabel.TabIndex = 12;
            pLZLabel.Text = "PLZ:";
            // 
            // ortLabel
            // 
            ortLabel.AutoSize = true;
            ortLabel.Location = new System.Drawing.Point(12, 199);
            ortLabel.Name = "ortLabel";
            ortLabel.Size = new System.Drawing.Size(24, 13);
            ortLabel.TabIndex = 14;
            ortLabel.Text = "Ort:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kontakteDatabaseDataSet
            // 
            this.kontakteDatabaseDataSet.DataSetName = "KontakteDatabaseDataSet";
            this.kontakteDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personenBindingSource
            // 
            this.personenBindingSource.DataMember = "Personen";
            this.personenBindingSource.DataSource = this.kontakteDatabaseDataSet;
            // 
            // personenTableAdapter
            // 
            this.personenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonenTableAdapter = this.personenTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kontakte.KontakteDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personenBindingNavigator
            // 
            this.personenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personenBindingNavigator.BindingSource = this.personenBindingSource;
            this.personenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personenBindingNavigatorSaveItem});
            this.personenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personenBindingNavigator.Name = "personenBindingNavigator";
            this.personenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personenBindingNavigator.Size = new System.Drawing.Size(370, 25);
            this.personenBindingNavigator.TabIndex = 1;
            this.personenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personenBindingNavigatorSaveItem
            // 
            this.personenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personenBindingNavigatorSaveItem.Image")));
            this.personenBindingNavigatorSaveItem.Name = "personenBindingNavigatorSaveItem";
            this.personenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personenBindingNavigatorSaveItem.Text = "Daten speichern";
            this.personenBindingNavigatorSaveItem.Click += new System.EventHandler(this.personenBindingNavigatorSaveItem_Click);
            // 
            // kontaktIDTextBox
            // 
            this.kontaktIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "KontaktID", true));
            this.kontaktIDTextBox.Location = new System.Drawing.Point(79, 40);
            this.kontaktIDTextBox.Name = "kontaktIDTextBox";
            this.kontaktIDTextBox.Size = new System.Drawing.Size(153, 20);
            this.kontaktIDTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(79, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(153, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(79, 92);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(153, 20);
            this.telefonTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(79, 118);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(153, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // strasseTextBox
            // 
            this.strasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Strasse", true));
            this.strasseTextBox.Location = new System.Drawing.Point(79, 144);
            this.strasseTextBox.Name = "strasseTextBox";
            this.strasseTextBox.Size = new System.Drawing.Size(153, 20);
            this.strasseTextBox.TabIndex = 11;
            // 
            // pLZTextBox
            // 
            this.pLZTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "PLZ", true));
            this.pLZTextBox.Location = new System.Drawing.Point(79, 170);
            this.pLZTextBox.Name = "pLZTextBox";
            this.pLZTextBox.Size = new System.Drawing.Size(153, 20);
            this.pLZTextBox.TabIndex = 13;
            // 
            // ortTextBox
            // 
            this.ortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Ort", true));
            this.ortTextBox.Location = new System.Drawing.Point(79, 196);
            this.ortTextBox.Name = "ortTextBox";
            this.ortTextBox.Size = new System.Drawing.Size(153, 20);
            this.ortTextBox.TabIndex = 15;
            // 
            // Adressliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(370, 266);
            this.Controls.Add(kontaktIDLabel);
            this.Controls.Add(this.kontaktIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(strasseLabel);
            this.Controls.Add(this.strasseTextBox);
            this.Controls.Add(pLZLabel);
            this.Controls.Add(this.pLZTextBox);
            this.Controls.Add(ortLabel);
            this.Controls.Add(this.ortTextBox);
            this.Controls.Add(this.personenBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adressliste";
            this.Text = "Adressliste";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingNavigator)).EndInit();
            this.personenBindingNavigator.ResumeLayout(false);
            this.personenBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private KontakteDatabaseDataSet kontakteDatabaseDataSet;
        private System.Windows.Forms.BindingSource personenBindingSource;
        private Kontakte.KontakteDatabaseDataSetTableAdapters.PersonenTableAdapter personenTableAdapter;
        private Kontakte.KontakteDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personenBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personenBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kontaktIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox strasseTextBox;
        private System.Windows.Forms.TextBox pLZTextBox;
        private System.Windows.Forms.TextBox ortTextBox;
    }
}

