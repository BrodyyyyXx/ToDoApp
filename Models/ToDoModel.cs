﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ToDoApp.Models
{
    class ToDoModel:INotifyPropertyChanged
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

		private bool _isDone;
        private string _text;

        public bool isDone
		{
			get { return _isDone; }
			set {
				if (_isDone == value)
					return;
				_isDone = value;
				OnProperetyChanged("isDone");
			}
		}

        public  string Text
		{
			get { return _text; }
			set {
				if(_text == value)
					return;
				_text = value;
				OnProperetyChanged("Text");
			}
		}

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnProperetyChanged(string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
