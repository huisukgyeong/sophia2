﻿using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.ViewModels
{
    class MenuViewModel : MvxViewModel
    {
        public MvxCommand MeasurementsViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<MeasurementsViewModel>());
            }
        }
        public MvxCommand GoalsViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<GoalSetupViewModel>());
            }
        }
        public MvxCommand InformationMenuViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<InformationMenuViewModel>());
            }
        }
        public MvxCommand CommunityMenuViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<CommunityMenuViewModel>());
            }
        }
    }
}
