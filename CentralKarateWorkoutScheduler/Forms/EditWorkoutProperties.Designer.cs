namespace CentralKarateWorkoutScheduler.Forms
{
    partial class EditWorkoutProperties
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.sfDataGridWorkoutProps = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.modelPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridWorkoutProps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPropertiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGridWorkoutProps
            // 
            this.sfDataGridWorkoutProps.AccessibleName = "Table";
            this.sfDataGridWorkoutProps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGridWorkoutProps.AutoGenerateColumns = false;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.HeaderText = "Name";
            gridTextColumn1.MappingName = "Name";
            gridTextColumn2.AllowMultiline = true;
            gridTextColumn2.AllowVerticalScrollbar = true;
            gridTextColumn2.HeaderText = "Value";
            gridTextColumn2.MappingName = "Value";
            this.sfDataGridWorkoutProps.Columns.Add(gridTextColumn1);
            this.sfDataGridWorkoutProps.Columns.Add(gridTextColumn2);
            this.sfDataGridWorkoutProps.DataSource = this.modelPropertiesBindingSource;
            this.sfDataGridWorkoutProps.LiveDataUpdateMode = Syncfusion.Data.LiveDataUpdateMode.AllowDataShaping;
            this.sfDataGridWorkoutProps.Location = new System.Drawing.Point(13, 13);
            this.sfDataGridWorkoutProps.Name = "sfDataGridWorkoutProps";
            this.sfDataGridWorkoutProps.Size = new System.Drawing.Size(775, 366);
            this.sfDataGridWorkoutProps.TabIndex = 0;
            this.sfDataGridWorkoutProps.Text = "sfDataGrid1";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(713, 415);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(632, 415);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // modelPropertiesBindingSource
            // 
            this.modelPropertiesBindingSource.DataSource = typeof(CentralKarateWorkoutScheduler.Classes.ModelProperties);
            // 
            // EditWorkoutProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.sfDataGridWorkoutProps);
            this.Name = "EditWorkoutProperties";
            this.Text = "EditWorkoutProperties";
            this.Load += new System.EventHandler(this.EditWorkoutProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridWorkoutProps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPropertiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridWorkoutProps;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.BindingSource modelPropertiesBindingSource;
    }
}