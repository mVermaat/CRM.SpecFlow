﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlatform.SpecflowExtensions.EasyRepro.Selenium
{
    public interface INavigation
    {
        void OpenRecord(OpenFormOptions options, Guid appId);
        void WaitForFormLoad(params IFormLoadCondition[] additionalConditions);
    }
}