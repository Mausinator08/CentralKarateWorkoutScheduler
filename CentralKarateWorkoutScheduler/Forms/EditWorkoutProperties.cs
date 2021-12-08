using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralKarateWorkoutScheduler.Forms
{
    public partial class EditWorkoutProperties : Form
    {
        private Models.Class _class = null;
        private Models.Routine _routine = null;
        private Models.Workout _workout = null;
        private string _modelType = null;
        private ObservableCollection<Classes.ModelProperties> _modelProperties = new ObservableCollection<Classes.ModelProperties>();

        public Models.Class Class
        {
            get => _class;
            set => _class = value;
        }

        public Models.Routine Routine
        {
            get => _routine;
            set => _routine = value;
        }

        public Models.Workout Workout
        {
            get => _workout;
            set => _workout = value;
        }

        public EditWorkoutProperties()
        {
            InitializeComponent();
        }

        private void EditWorkoutProperties_Load(object sender, EventArgs e)
        {
            sfDataGridWorkoutProps.DataSource = _modelProperties;
        }

        public void SetClassToDataSource(Models.Class cls)
        {
            _modelProperties.Clear();
            _modelProperties.Add(new Classes.ModelProperties(nameof(cls.StartHour), cls.StartHour.ToString()));
            _modelProperties.Add(new Classes.ModelProperties(nameof(cls.StartMinute), cls.StartMinute.ToString()));
            _modelProperties.Add(new Classes.ModelProperties(nameof(cls.DisplayName), cls.DisplayName));
            _modelProperties.Add(new Classes.ModelProperties(nameof(cls.DurationInMinutes), cls.DurationInMinutes.ToString()));
            _modelType = nameof(Models.Class);
            _class = cls;
        }

        public void SetRoutineToDataSource(Models.Routine routine)
        {
            _modelProperties.Clear();
            _modelProperties.Add(new Classes.ModelProperties(nameof(routine.DisplayName), routine.DisplayName));
            _modelType = nameof(Models.Routine);
            _routine = routine;
        }

        public void SetWorkoutToDataSource(Models.Workout workout)
        {
            _modelProperties.Clear();
            _modelProperties.Add(new Classes.ModelProperties(nameof(workout.DisplayName), workout.DisplayName));
            _modelProperties.Add(new Classes.ModelProperties(nameof(workout.Description), workout.Description));
            _modelType = nameof(Models.Workout);
            _workout = workout;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TODO: Implement data validation when saving.
            if (_modelType != null)
            {
                switch (_modelType)
                {
                    case nameof(Models.Class):
                        {
                            foreach(Classes.ModelProperties mp in _modelProperties)
                            {
                                switch (mp.Name)
                                {
                                    case nameof(Models.Class.DisplayName):
                                        {
                                            if (_class != null)
                                            {
                                                _class.DisplayName = mp.Value;
                                            }
                                        }
                                        break;
                                    case nameof(Models.Class.DurationInMinutes):
                                        {
                                            if (_class != null)
                                            {
                                                _class.DurationInMinutes = Convert.ToInt32(mp.Value);
                                            }
                                        }
                                        break;
                                    case nameof(Models.Class.StartHour):
                                        {
                                            if (_class != null)
                                            {
                                                _class.StartHour = Convert.ToInt32(mp.Value);
                                            }
                                        }
                                        break;
                                    case nameof(Models.Class.StartMinute):
                                        {
                                            if (_class != null)
                                            {
                                                _class.StartMinute = Convert.ToInt32(mp.Value);
                                            }
                                        }
                                        break;
                                    default:
                                        {
                                            MessageBox.Show("Could not determine property for class!", "Warning!");
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case nameof(Models.Routine):
                        {
                            foreach (Classes.ModelProperties mp in _modelProperties)
                            {
                                switch (mp.Name)
                                {
                                    case nameof(Models.Routine.DisplayName):
                                        {
                                            if (_routine != null)
                                            {
                                                _routine.DisplayName = mp.Value;
                                            }
                                        }
                                        break;
                                    default:
                                        {
                                            MessageBox.Show("Could not determine property for class!", "Warning!");
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case nameof(Models.Workout):
                        {
                            foreach (Classes.ModelProperties mp in _modelProperties)
                            {
                                switch (mp.Name)
                                {
                                    case nameof(Models.Workout.DisplayName):
                                        {
                                            if (_workout != null)
                                            {
                                                _workout.DisplayName = mp.Value;
                                            }
                                        }
                                        break;
                                    case nameof(Models.Workout.Description):
                                        {
                                            if (_workout != null)
                                            {
                                                _workout.Description = mp.Value;
                                            }
                                        }
                                        break;
                                    default:
                                        {
                                            MessageBox.Show("Could not determine property for class!", "Warning!");
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Could not determine model!", "Warning!");
                        }
                        break;
                }

                this.DialogResult = DialogResult.OK;
                Close();

                return;
            }
            else
            {
                MessageBox.Show("Model type could not be determined!", "Warning!");
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _modelProperties.Clear();
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
