﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.SampleDataSource1
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class SampleDataSource1 { }
#else

	public class SampleDataSource1 : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public SampleDataSource1()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/EcoManager;component/SampleData/SampleDataSource1/SampleDataSource1.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private WorkEntities _WorkEntities = new WorkEntities();

		public WorkEntities WorkEntities
		{
			get
			{
				return this._WorkEntities;
			}
		}
	}

	public class WorkEntitiesItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private bool _Completed = false;

		public bool Completed
		{
			get
			{
				return this._Completed;
			}

			set
			{
				if (this._Completed != value)
				{
					this._Completed = value;
					this.OnPropertyChanged("Completed");
				}
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}
	}

	public class WorkEntities : System.Collections.ObjectModel.ObservableCollection<WorkEntitiesItem>
	{ 
	}
#endif
}
