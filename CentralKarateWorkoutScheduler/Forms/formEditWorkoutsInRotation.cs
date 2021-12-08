using CentralKarateWorkoutScheduler.Models;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		private XPCollection<Class> classes = null;
		private UnitOfWork uow = new UnitOfWork();
		private EditWorkoutProperties editForm = null;
		private ObservableCollection<Classes.ModelProperties> _modelProperties = new ObservableCollection<Classes.ModelProperties>();
		ChangeValue editName = null;

		public formEditWorkoutsInRotation()
		{
			InitializeComponent();
			classes = new XPCollection<Class>(uow);
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
			classes.Load();

			sfDataGridModelProperties.DataSource = _modelProperties;

			var cls = classes;

			if (cls.Any() == true)
			{
				var wir = treeviewWorkoutsInRotation.Nodes.Find("WorkoutsInRotation", false);

				foreach (var c in cls.OrderBy(i => i.StartHour & i.StartMinute).ToList())
				{
					TreeNode node = new TreeNode()
					{
						Tag = "class",
						Name = c.Name,
						Text = c.DisplayName
					};

					if (c.Routines.Any() == true)
					{
						foreach (var r in c.Routines.ToList())
						{
							TreeNode rnode = new TreeNode()
							{
								Tag = "routine",
								Name = r.Name,
								Text = r.DisplayName
							};

							if (r.Workouts.Any() == true)
							{
								foreach (var w in r.Workouts.ToList())
								{
									TreeNode wnode = new TreeNode()
									{
										Tag = "workout",
										Name = w.Name,
										Text = w.DisplayName
									};

									rnode.Nodes.Add(wnode);
								}
							}

							node.Nodes.Add(rnode);
						}
					}

					wir.First().Nodes.Add(node);
				}
			}
		}

		private void buttonAddClass_Click(object sender, EventArgs e)
		{
			if (textBoxNewNodeText.Text == "" || textBoxNewNodeText.Text == null)
			{
				editName = new ChangeValue();
				editName.SetTitle("New Class");
				editName.SetDataDescription("Class Name:");
				editName.SetDataValue("Class");
				var result = editName.ShowDialog();

				if (result == DialogResult.OK)
				{
					textBoxNewNodeText.Text = editName.Value;
					editName = null;
				}
				else
                {
					editName = null;
					return;
                }
			}

			Guid guid = Guid.NewGuid();

			if (selectedNode.Tag.ToString() == "root")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "class",
					Name = textBoxNewNodeText.Text + $"{{{guid.ToString()}}}",
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				classes.Add(new Class(uow)
				{
					Id = guid,
					Name = node.Name,
					DisplayName = node.Text,
					StartHour = 0,
					StartMinute = 0,
					DurationInMinutes = 0
				});

				return;
			}

			if (selectedNode.Tag.ToString() == "class")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "class",
					Name = textBoxNewNodeText.Text + $"{{{guid.ToString()}}}",
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				classes.Add(new Class(uow)
				{
					Id = guid,
					Name = node.Name,
					DisplayName = node.Text,
					StartHour = 0,
					StartMinute = 0,
					DurationInMinutes = 0
				});

				return;
			}

			if (selectedNode.Tag.ToString() == "routine")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "class",
					Name = textBoxNewNodeText.Text + $"{{{guid.ToString()}}}",
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				classes.Add(new Class(uow)
				{
					Id = guid,
					Name = node.Name,
					DisplayName = node.Text,
					StartHour = 0,
					StartMinute = 0,
					DurationInMinutes = 0
				});

				return;
			}

			if (selectedNode.Tag.ToString() == "workout")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "class",
					Name = textBoxNewNodeText.Text + $"{{{guid.ToString()}}}",
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Parent.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				classes.Add(new Class(uow)
				{
					Id = guid,
					Name = node.Name,
					DisplayName = node.Text,
					StartHour = 0,
					StartMinute = 0,
					DurationInMinutes = 0
				});

				return;
			}
		}

		private void FillClassDataGrid(TreeNode node)
        {
			_modelProperties.Clear();

			if (classes.Where(i => i.Name == node.Name).Any())
			{
				var cls = classes.Where(i => i.Name == node.Name).First();

				_modelProperties.Add(new Classes.ModelProperties(nameof(cls.StartHour), cls.StartHour.ToString()));
				_modelProperties.Add(new Classes.ModelProperties(nameof(cls.StartMinute), cls.StartMinute.ToString()));
				_modelProperties.Add(new Classes.ModelProperties(nameof(cls.DisplayName), cls.DisplayName));
				_modelProperties.Add(new Classes.ModelProperties(nameof(cls.DurationInMinutes), cls.DurationInMinutes.ToString()));
			}
		}

		private void FillRoutineDataGrid(TreeNode node)
        {
			_modelProperties.Clear();

			if (classes.Where(i => i.Name == node.Parent.Name).Any())
			{
				var cls = classes.Where(i => i.Name == node.Parent.Name).First();

				if (cls.Routines.Where(i => i.Name == node.Name).Any())
				{
					var routine = cls.Routines.Where(i => i.Name == node.Name).First();

					_modelProperties.Add(new Classes.ModelProperties(nameof(routine.DisplayName), routine.DisplayName));
				}
			}
		}

		private void FillWorkoutDataGrid(TreeNode node)
		{
			_modelProperties.Clear();

			if (classes.Where(i => i.Name == node.Parent.Parent.Name).Any())
			{
				var cls = classes.Where(i => i.Name == node.Parent.Parent.Name).First();

				if (cls.Routines.Where(i => i.Name == node.Parent.Name).Any())
				{
					var routine = cls.Routines.Where(i => i.Name == node.Parent.Name).First();

					if (routine.Workouts.Where(i => i.Name == node.Name).Any())
					{
						var workout = routine.Workouts.Where(i => i.Name == node.Name).First();

						_modelProperties.Add(new Classes.ModelProperties(nameof(workout.DisplayName), workout.DisplayName));
						_modelProperties.Add(new Classes.ModelProperties(nameof(workout.Description), workout.Description));
					}
				}
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

				_modelProperties.Clear();

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

				FillClassDataGrid(e.Node);

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

				FillRoutineDataGrid(e.Node);

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

				FillWorkoutDataGrid(e.Node);

				return;
			}
		}

		private void buttonAddRoutine_Click(object sender, EventArgs e)
		{
			if (textBoxNewNodeText.Text == "" || textBoxNewNodeText.Text == null)
			{
				editName = new ChangeValue();
				editName.SetTitle("New Routine");
				editName.SetDataDescription("Routine Name:");
				editName.SetDataValue("Routine");
				var result = editName.ShowDialog();

				if (result == DialogResult.OK)
				{
					textBoxNewNodeText.Text = editName.Value;
					editName = null;
				}
				else
				{
					editName = null;
					return;
				}
			}

			Guid guid = Guid.NewGuid();

			if (selectedNode.Tag.ToString() == "class")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "routine",
					Name = textBoxNewNodeText.Text + $"{{{guid.ToString()}}}",
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				var cls = classes.Where(i =>
				i.Name == node.Parent.Name);

				if (cls.Any() == true)
				{
					cls.First().Routines.Add(new Routine(uow)
					{
						Id = guid,
						Name = node.Name,
						DisplayName = node.Text,
						ClassRef = cls.First()
					});
				}

				return;
			}

			if (selectedNode.Tag.ToString() == "routine")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "routine",
					Name = textBoxNewNodeText.Text + $"{{{guid.ToString()}}}",
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				var cls = classes.Where(i =>
				i.Name == node.Parent.Name);

				if (cls.Any() == true)
				{
					cls.First().Routines.Add(new Routine(uow)
					{
						Id = guid,
						Name = node.Name,
						DisplayName = node.Text,
						ClassRef = cls.First()
					});
				}

				return;
			}

			if (selectedNode.Tag.ToString() == "workout")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "routine",
					Name = textBoxNewNodeText.Text + $"{{{guid.ToString()}}}",
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				var cls = classes.Where(i =>
				i.Name == node.Parent.Name);

				if (cls.Any() == true)
				{
					cls.First().Routines.Add(new Routine(uow)
					{
						Id = guid,
						Name = node.Name,
						DisplayName = node.Text,
						ClassRef = cls.First()
					});
				}

				return;
			}
		}

		private void buttonAddWorkout_Click(object sender, EventArgs e)
		{
			if (textBoxNewNodeText.Text == "" || textBoxNewNodeText.Text == null)
			{
				editName = new ChangeValue();
				editName.SetTitle("New Workout");
				editName.SetDataDescription("Workout Name:");
				editName.SetDataValue("Workout");
				var result = editName.ShowDialog();

				if (result == DialogResult.OK)
				{
					textBoxNewNodeText.Text = editName.Value;
					editName = null;
				}
				else
				{
					editName = null;
					return;
				}
			}

			Guid guid = Guid.NewGuid();

			if (selectedNode.Tag.ToString() == "routine")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "workout",
					Name = textBoxNewNodeText.Text + $"{{{guid.ToString()}}}",
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				var cls = classes.Where(i =>
				i.Name == node.Parent.Parent.Name);

				if (cls.Any() == true)
				{
					var routine = cls.First().Routines.Where(i => i.Name == node.Parent.Name);
					
					if (routine.Any() == true)
					{
						routine.First().Workouts.Add(new Workout(uow)
						 {
							 Id = guid,
							 Name = node.Name,
							 DisplayName = node.Text,
							 Description = null,
							 RoutineRef = routine.First()
						 });
					}
				}

				return;
			}

			if (selectedNode.Tag.ToString() == "workout")
			{
				TreeNode node = new TreeNode()
				{
					Tag = "workout",
					Name = textBoxNewNodeText.Text + $"{{{guid.ToString()}}}",
					Text = textBoxNewNodeText.Text
				};

				selectedNode.Parent.Nodes.Add(node);

				textBoxNewNodeText.Text = "";

				var cls = classes.Where(i =>
				i.Name == node.Parent.Parent.Name);

				if (cls.Any() == true)
				{
					var routine = cls.First().Routines.Where(i => i.Name == node.Parent.Name);

					if (routine.Any() == true)
					{
						routine.First().Workouts.Add(new Workout(uow)
						{
							Id = guid,
							Name = node.Name,
							DisplayName = node.Text,
							Description = null,
							RoutineRef = routine.First()
						});
					}
				}

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

				if (selectedNode.Tag.ToString() == "class")
                {
					var cls = classes.Where(i => i.Name == selectedNode.Name);

					if (cls.Any())
                    {
						cls.First().DisplayName = selectedNode.Text;
                    }
				}

				if (selectedNode.Tag.ToString() == "routine")
				{
					var cls = classes.Where(i => i.Name == selectedNode.Parent.Name);

					if (cls.Any())
					{
						var routine = cls.First().Routines.Where(i => i.Name == selectedNode.Name);

						if (routine.Any())
                        {
							routine.First().DisplayName = selectedNode.Text;
                        }
					}
				}

				if (selectedNode.Tag.ToString() == "workout")
				{
					var cls = classes.Where(i => i.Name == selectedNode.Parent.Parent.Name);

					if (cls.Any())
					{
						var routine = cls.First().Routines.Where(i => i.Name == selectedNode.Parent.Name);

						if (routine.Any())
						{
							var workout = routine.First().Workouts.Where(i => i.Name == selectedNode.Name);

							if (workout.Any())
                            {
								workout.First().DisplayName = selectedNode.Text;
                            }
						}
					}
				}
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			uow.CommitChanges();
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Any changes you have made will be lost! Are you sure?", "WARNING!", MessageBoxButtons.YesNo) == DialogResult.Yes)
				Close();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (selectedNode.Tag.ToString() == "root")
			{
				MessageBox.Show("Please select a node other than the root node!");

				return;
			}

			if (selectedNode.Tag.ToString() == "class")
            {
				editForm = new EditWorkoutProperties();
				
				var cls = classes.Where(i => i.Name == selectedNode.Name);

				if (cls.Any())
				{
					editForm.SetClassToDataSource(cls.First());
					var result = editForm.ShowDialog();

					if (result == DialogResult.OK)
					{
						classes.Remove(cls.First());
						classes.Add(editForm.Class);

						FillClassDataGrid(selectedNode);
					}

					editForm = null;
				}
				else
                {
					MessageBox.Show("Class does not exist in database!", "Error");
                }

				return;
			}

			if (selectedNode.Tag.ToString() == "routine")
			{
				editForm = new EditWorkoutProperties();

				var cls = classes.Where(i => i.Name == selectedNode.Parent.Name);

				if (cls.Any())
				{
					var routine = cls.First().Routines.Where(i => i.Name == selectedNode.Name);

					if (routine.Any())
					{
						editForm.SetRoutineToDataSource(routine.First());
						var result = editForm.ShowDialog();

						if (result == DialogResult.OK)
						{
							cls.First().Routines.Remove(routine.First());
							cls.First().Routines.Add(editForm.Routine);

							FillRoutineDataGrid(selectedNode);
						}

						editForm = null;
					}
				}
				else
				{
					MessageBox.Show("Routine does not exist in database!", "Error");
				}

				return;
			}

			if (selectedNode.Tag.ToString() == "workout")
			{
				editForm = new EditWorkoutProperties();

				var cls = classes.Where(i => i.Name == selectedNode.Parent.Parent.Name);

				if (cls.Any())
				{
					var routine = cls.First().Routines.Where(i => i.Name == selectedNode.Parent.Name);

					if (routine.Any())
					{
						var workout = routine.First().Workouts.Where(i => i.Name == selectedNode.Name);

						if (workout.Any())
						{
							editForm.SetWorkoutToDataSource(workout.First());
							var result = editForm.ShowDialog();

							if (result == DialogResult.OK)
							{
								routine.First().Workouts.Remove(workout.First());
								routine.First().Workouts.Add(editForm.Workout);

								FillWorkoutDataGrid(selectedNode);
							}

							editForm = null;
						}
					}
				}
				else
				{
					MessageBox.Show("Routine does not exist in database!", "Error");
				}

				return;
			}
		}
	}
}
