using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CentralKarateWorkoutScheduler.Forms
{
	public partial class formEditWorkoutsInRotation : Form
	{
		private TreeNode selectedNode = null;

		public formEditWorkoutsInRotation()
		{
			InitializeComponent();
		}

		private void formEditWorkoutsInRotation_Load(object sender, EventArgs e)
		{
			treeviewWorkoutsInRotation.SelectedNode = treeviewWorkoutsInRotation.Nodes.Find("WorkoutsInRotation", false)[0];
			selectedNode = treeviewWorkoutsInRotation.SelectedNode;
			buttonAddClass.Enabled = true;
			buttonAddRoutine.Enabled = false;
			buttonAddWorkout.Enabled = false;
			buttonMoveUp.Enabled = false;
			buttonMoveDown.Enabled = false;
			buttonRemoveItem.Enabled = false;
			textBoxNodeText.Text = "Workouts In Rotation";
			textBoxNodeText.Enabled = false;
		}

		private void buttonAddClass_Click(object sender, EventArgs e)
		{
			if (textBoxNewNodeText.Text == "" || textBoxNewNodeText.Text == null)
			{
				MessageBox.Show("Please specify text in the [New Node Text] box to create a new node!");

				return;
			}

			if (selectedNode.Tag.ToString() == "root")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "class",
					Name = textBoxNewNodeText.Text + Guid.NewGuid().ToString(),
					Text = textBoxNewNodeText.Text
				};


				selectedNode.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				return;
			}

			if (selectedNode.Tag.ToString() == "class")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "class",
					Name = textBoxNewNodeText.Text + Guid.NewGuid().ToString(),
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				return;
			}

			if (selectedNode.Tag.ToString() == "routine")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "class",
					Name = textBoxNewNodeText.Text + Guid.NewGuid().ToString(),
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				return;
			}

			if (selectedNode.Tag.ToString() == "workout")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "class",
					Name = textBoxNewNodeText.Text + Guid.NewGuid().ToString(),
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Parent.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				return;
			}
		}

		private void treeviewWorkoutsInRotation_AfterSelect(object sender, TreeViewEventArgs e)
		{
			selectedNode = e.Node;
			textBoxNodeText.Text = e.Node.Text;

			if (e.Node.Tag.ToString() == "root")
			{
				buttonAddClass.Enabled = true;
				buttonAddRoutine.Enabled = false;
				buttonAddWorkout.Enabled = false;
				buttonMoveUp.Enabled = false;
				buttonMoveDown.Enabled = false;
				buttonRemoveItem.Enabled = false;
				textBoxNodeText.Enabled = false;
				return;
			}

			if (e.Node.Tag.ToString() == "class")
			{
				buttonAddClass.Enabled = true;
				buttonAddRoutine.Enabled = true;
				buttonAddWorkout.Enabled = false;
				buttonMoveUp.Enabled = true;
				buttonMoveDown.Enabled = true;
				buttonRemoveItem.Enabled = true;
				textBoxNodeText.Enabled = true;
				return;
			}

			if (e.Node.Tag.ToString() == "routine")
			{
				buttonAddClass.Enabled = true;
				buttonAddRoutine.Enabled = true;
				buttonAddWorkout.Enabled = true;
				buttonMoveUp.Enabled = true;
				buttonMoveDown.Enabled = true;
				buttonRemoveItem.Enabled = true;
				textBoxNodeText.Enabled = true;
				return;
			}

			if (e.Node.Tag.ToString() == "workout")
			{
				buttonAddClass.Enabled = true;
				buttonAddRoutine.Enabled = true;
				buttonAddWorkout.Enabled = true;
				buttonMoveUp.Enabled = true;
				buttonMoveDown.Enabled = true;
				buttonRemoveItem.Enabled = true;
				textBoxNodeText.Enabled = true;
				return;
			}
		}

		private void buttonAddRoutine_Click(object sender, EventArgs e)
		{
			if (textBoxNewNodeText.Text == "" || textBoxNewNodeText.Text == null)
			{
				MessageBox.Show("Please specify text in the [New Node Text] box to create a new node!");

				return;
			}

			if (selectedNode.Tag.ToString() == "class")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "routine",
					Name = textBoxNewNodeText.Text + Guid.NewGuid().ToString(),
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				return;
			}

			if (selectedNode.Tag.ToString() == "routine")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "routine",
					Name = textBoxNewNodeText.Text + Guid.NewGuid().ToString(),
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				return;
			}

			if (selectedNode.Tag.ToString() == "workout")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "routine",
					Name = textBoxNewNodeText.Text + Guid.NewGuid().ToString(),
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				return;
			}
		}

		private void buttonAddWorkout_Click(object sender, EventArgs e)
		{
			if (textBoxNewNodeText.Text == "" || textBoxNewNodeText.Text == null)
			{
				MessageBox.Show("Please specify text in the [New Node Text] box to create a new node!");

				return;
			}

			if (selectedNode.Tag.ToString() == "routine")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "workout",
					Name = textBoxNewNodeText.Text + Guid.NewGuid().ToString(),
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				return;
			}

			if (selectedNode.Tag.ToString() == "workout")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "workout",
					Name = textBoxNewNodeText.Text + Guid.NewGuid().ToString(),
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				return;
			}
		}

		private void buttonRemoveItem_Click(object sender, EventArgs e)
		{
			selectedNode.Remove();
			selectedNode = treeviewWorkoutsInRotation.Nodes.Find("WorkoutsInRotation", false)[0];
			buttonAddClass.Enabled = true;
			buttonAddRoutine.Enabled = false;
			buttonAddWorkout.Enabled = false;
			buttonMoveUp.Enabled = false;
			buttonMoveDown.Enabled = false;
			buttonRemoveItem.Enabled = false;
			textBoxNodeText.Enabled = false;
			textBoxNodeText.Text = selectedNode.Text;
		}

		private void buttonMoveUp_Click(object sender, EventArgs e)
		{
			if (selectedNode.Index > 0)
			{
				TreeNode movedNode = selectedNode.Parent.Nodes.Insert(selectedNode.Index - 1, selectedNode.Text);
				movedNode.Tag = selectedNode.Tag;

				TreeNode[] selectedNodeChildren = new TreeNode[selectedNode.Nodes.Count];
				selectedNode.Nodes.CopyTo(selectedNodeChildren, 0);

				foreach (TreeNode node in selectedNodeChildren)
				{
					selectedNode.Nodes[node.Index].Remove();
					movedNode.Nodes.Add(node);
				}

				string name = selectedNode.Name;
				selectedNode.Remove();
				movedNode.Name = name;

				selectedNode = movedNode;
			}
		}

		private void buttonMoveDown_Click(object sender, EventArgs e)
		{
			if (selectedNode.Index < selectedNode.GetNodeCount(false))
			{
				TreeNode movedNode = selectedNode.Parent.Nodes.Insert(selectedNode.Index + 2, selectedNode.Text);
				movedNode.Tag = selectedNode.Tag;

				TreeNode[] selectedNodeChildren = new TreeNode[selectedNode.Nodes.Count];
				selectedNode.Nodes.CopyTo(selectedNodeChildren, 0);

				foreach (TreeNode node in selectedNodeChildren)
				{
					selectedNode.Nodes[node.Index].Remove();
					movedNode.Nodes.Add(node);
				}

				string name = selectedNode.Name;
				selectedNode.Remove();
				movedNode.Name = name;

				selectedNode = movedNode;
			}
		}

		private void textBoxNodeText_TextChanged(object sender, EventArgs e)
		{
			if (selectedNode != null)
			{
				selectedNode.Text = textBoxNodeText.Text;
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			Directory.CreateDirectory(@"Data");

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Any changes you have made will be lost! Are you sure?", "WARNING!", MessageBoxButtons.YesNo) == DialogResult.Yes)
				Close();
		}
	}
}
