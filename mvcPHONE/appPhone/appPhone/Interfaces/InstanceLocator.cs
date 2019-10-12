using System;
using System.Collections.Generic;
using System.Text;

namespace appPhone.Interfaces
{
    using ViewModels;//sale rojo porque no esta creado todavia el ViewModels
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion  
        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
