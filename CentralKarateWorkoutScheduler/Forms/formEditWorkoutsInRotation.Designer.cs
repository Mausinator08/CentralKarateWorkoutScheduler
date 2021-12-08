
namespace CentralKarateWorkoutScheduler.Forms
{
	partial class formEditWorkoutsInRotation
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Workouts In Rotation");
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.treeviewWorkoutsInRotation = new System.Windows.Forms.TreeView();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonAddWorkout = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonAddRoutine = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxNodeText = new System.Windows.Forms.TextBox();
            this.labelNodeText = new System.Windows.Forms.Label();
            this.textBoxNewNodeText = new System.Windows.Forms.TextBox();
            this.labelNewNodeText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.sfDataGridModelProperties = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.modelPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridModelProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPropertiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeviewWorkoutsInRotation
            // 
            this.treeviewWorkoutsInRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeviewWorkoutsInRotation.Location = new System.Drawing.Point(13, 13);
            this.treeviewWorkoutsInRotation.Name = "treeviewWorkoutsInRotation";
            treeNode2.Name = "WorkoutsInRotation";
            treeNode2.Tag = "root";
            treeNode2.Text = "Workouts In Rotation";
            this.treeviewWorkoutsInRotation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeviewWorkoutsInRotation.Size = new System.Drawing.Size(204, 205);
            this.treeviewWorkoutsInRotation.TabIndex = 0;
            this.treeviewWorkoutsInRotation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeviewWorkoutsInRotation_AfterSelect);
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.Location = new System.Drawing.Point(11, 18);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(103, 23);
            this.buttonAddClass.TabIndex = 14;
            this.buttonAddClass.Text = "Add Class";
            this.buttonAddClass.UseVisualStyleBackColor = true;
            this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
            // 
            // buttonAddWorkout
            // 
            this.buttonAddWorkout.Location = new System.Drawing.Point(11, 79);
            this.buttonAddWorkout.Name = "buttonAddWorkout";
            this.buttonAddWorkout.Size = new System.Drawing.Size(103, 23);
            this.buttonAddWorkout.TabIndex = 15;
            this.buttonAddWorkout.Text = "Add Workout";
            this.buttonAddWorkout.UseVisualStyleBackColor = true;
            this.buttonAddWorkout.Click += new System.EventHandler(this.buttonAddWorkout_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(11, 108);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(103, 23);
            this.buttonRemoveItem.TabIndex = 16;
            this.buttonRemoveItem.Text = "Remove Item";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(11, 137);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveUp.TabIndex = 17;
            this.buttonMoveUp.Text = "Move Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonAddRoutine
            // 
            this.buttonAddRoutine.Location = new System.Drawing.Point(12, 48);
            this.buttonAddRoutine.Name = "buttonAddRoutine";
            this.buttonAddRoutine.Size = new System.Drawing.Size(102, 23);
            this.buttonAddRoutine.TabIndex = 18;
            this.buttonAddRoutine.Text = "Add Routine";
            this.buttonAddRoutine.UseVisualStyleBackColor = true;
            this.buttonAddRoutine.Click += new System.EventHandler(this.buttonAddRoutine_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(12, 167);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveDown.TabIndex = 19;
            this.buttonMoveDown.Text = "Move Down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 371);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(103, 23);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 409);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxNodeText
            // 
            this.textBoxNodeText.Location = new System.Drawing.Point(12, 221);
            this.textBoxNodeText.Multiline = true;
            this.textBoxNodeText.Name = "textBoxNodeText";
            this.textBoxNodeText.Size = new System.Drawing.Size(178, 55);
            this.textBoxNodeText.TabIndex = 22;
            this.textBoxNodeText.TextChanged += new System.EventHandler(this.textBoxNodeText_TextChanged);
            // 
            // labelNodeText
            // 
            this.labelNodeText.AutoSize = true;
            this.labelNodeText.Location = new System.Drawing.Point(12, 205);
            this.labelNodeText.Name = "labelNodeText";
            this.labelNodeText.Size = new System.Drawing.Size(103, 13);
            this.labelNodeText.TabIndex = 23;
            this.labelNodeText.Text = "Rename Node Text:";
            // 
            // textBoxNewNodeText
            // 
            this.textBoxNewNodeText.Location = new System.Drawing.Point(11, 310);
            this.textBoxNewNodeText.Multiline = true;
            this.textBoxNewNodeText.Name = "textBoxNewNodeText";
            this.textBoxNewNodeText.Size = new System.Drawing.Size(179, 55);
            this.textBoxNewNodeText.TabIndex = 24;
            // 
            // labelNewNodeText
            // 
            this.labelNewNodeText.AutoSize = true;
            this.labelNewNodeText.Location = new System.Drawing.Point(12, 294);
            this.labelNewNodeText.Name = "labelNewNodeText";
            this.labelNewNodeText.Size = new System.Drawing.Size(85, 13);
            this.labelNewNodeText.TabIndex = 25;
            this.labelNewNodeText.Text = "New Node Text:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.labelNewNodeText);
            this.panel1.Controls.Add(this.textBoxNewNodeText);
            this.panel1.Controls.Add(this.labelNodeText);
            this.panel1.Controls.Add(this.textBoxNodeText);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonMoveDown);
            this.panel1.Controls.Add(this.buttonAddRoutine);
            this.panel1.Controls.Add(this.buttonMoveUp);
            this.panel1.Controls.Add(this.buttonRemoveItem);
            this.panel1.Controls.Add(this.buttonAddWorkout);
            this.panel1.Controls.Add(this.buttonAddClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(223, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 14;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(113, 166);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Edit Details";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // sfDataGridModelProperties
            // 
            this.sfDataGridModelProperties.AccessibleName = "Table";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn3.HeaderText = "Name";
            gridTextColumn3.MappingName = "Name";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn4.HeaderText = "Value";
            gridTextColumn4.MappingName = "Value";
            this.sfDataGridModelProperties.Columns.Add(gridTextColumn3);
            this.sfDataGridModelProperties.Columns.Add(gridTextColumn4);
            this.sfDataGridModelProperties.DataSource = this.modelPropertiesBindingSource;
            this.sfDataGridModelProperties.LiveDataUpdateMode = Syncfusion.Data.LiveDataUpdateMode.AllowDataShaping;
            this.sfDataGridModelProperties.Location = new System.Drawing.Point(12, 271);
            this.sfDataGridModelProperties.Name = "sfDataGridModelProperties";
            this.sfDataGridModelProperties.Size = new System.Drawing.Size(204, 167);
            this.sfDataGridModelProperties.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.sfDataGridModelProperties.TabIndex = 15;
            this.sfDataGridModelProperties.Text = "sfDataGrid1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Details:";
            // 
            // modelPropertiesBindingSource
            // 
            this.modelPropertiesBindingSource.DataSource = typeof(CentralKarateWorkoutScheduler.Classes.ModelProperties);
            // 
            // formEditWorkoutsInRotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sfDataGridModelProperties);
            this.Controls.Add(this.treeviewWorkoutsInRotation);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(439, 489);
            this.MinimumSize = new System.Drawing.Size(439, 489);
            this.Name = "formEditWorkoutsInRotation";
            this.Text = "Workouts in Rotation Editor";
            this.Load += new System.EventHandler(this.formEditWorkoutsInRotation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridModelProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPropertiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeviewWorkoutsInRotation;
		private System.Windows.Forms.Button buttonAddClass;
		private System.Windows.Forms.Button buttonAddWorkout;
		private System.Windows.Forms.Button buttonRemoveItem;
		private System.Windows.Forms.Button buttonMoveUp;
		private System.Windows.Forms.Button buttonAddRoutine;
		private System.Windows.Forms.Button buttonMoveDown;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxNodeText;
		private System.Windows.Forms.Label labelNodeText;
		private System.Windows.Forms.TextBox textBoxNewNodeText;
		private System.Windows.Forms.Label labelNewNodeText;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonEdit;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridModelProperties;
        private System.Windows.Forms.BindingSource modelPropertiesBindingSource;
        private System.Windows.Forms.Label label1;
    }
}