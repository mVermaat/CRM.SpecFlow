﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vermaat.Crm.Specflow.EasyRepro
{
    internal class SeleniumSelectorData
    {
        private readonly Dictionary<SeleniumSelectorItems, string> _selectors = new Dictionary<SeleniumSelectorItems, string>()
        {
            { SeleniumSelectorItems.Dialog_Subtitle, "//h2[@id='subtitle']" },
            { SeleniumSelectorItems.Dialog_ErrorDialog, "//div[@data-id='errorDialogdialog']" },
            { SeleniumSelectorItems.DuplicateDetection_Grid, "//div[@data-id='manage_duplicates_grid.fieldControl.ManageDuplicatesGrid_container']"},
            { SeleniumSelectorItems.DuplicateDetection_SelectedItems, ".//div[@aria-checked='true']/.."},
            { SeleniumSelectorItems.Entity_FormNotifcation_NotificationBar, "//div[@data-id='notificationWrapper']" },
            { SeleniumSelectorItems.Entity_FormNotifcation_ExpandButton, ".//span[@id='notificationExpandIcon']" },
            { SeleniumSelectorItems.Entity_FormNotifcation_NotificationList, ".//ul[@data-id='notificationList']" },
            { SeleniumSelectorItems.Entity_FormNotifcation_NotificationTypeIcon, ".//span[contains(@id,'notification_icon_')]" },
            { SeleniumSelectorItems.Entity_FormNotification_NotificationMessage, ".//span[@data-id='warningNotification']" },
            { SeleniumSelectorItems.Entity_SubGrid, "//div[@id=\"dataSetRoot_[NAME]\"]" },
            { SeleniumSelectorItems.Entity_SubGrid_ButtonList, ".//ul[@data-id='CommandBar']" },
            { SeleniumSelectorItems.Entity_SubGrid_Button, ".//button[contains(@data-id,'[NAME]')]" },
            { SeleniumSelectorItems.FlyoutRoot, "//div[@id='__flyoutRootNode']" },
            { SeleniumSelectorItems.Entity_ScriptErrorDialog, "//*[@id='dialogTitleText']" },
            { SeleniumSelectorItems.Entity_FormLoad, "//ul[contains(@id, 'tablist_')]" },
            { SeleniumSelectorItems.Entity_MoreTabs, ".//button[@data-id='more_button']" },
            { SeleniumSelectorItems.Entity_DateContainer, "//div[contains(@data-id,'[NAME].fieldControl._datecontrol-date-container')]" },
            { SeleniumSelectorItems.Entity_DateTime_Time_Input, ".//input[contains(@id, 'DatePicker')]" },
            { SeleniumSelectorItems.Entity_Footer_Status, "//span[@data-id='edit-form-status-message']" },
            { SeleniumSelectorItems.Entity_FormState_LockedIcon, "//div[@data-id='[NAME]-locked-icon']" },
            { SeleniumSelectorItems.Entity_FormState_RequiredOrRecommended, "//div[contains(@id, '[NAME]-required-icon')]" },
            { SeleniumSelectorItems.Dialog_Container, "id(\"dialogContentContainer_1\")" },
            { SeleniumSelectorItems.Entity_FieldContainer, "//div[@data-id='[NAME]']" },
            { SeleniumSelectorItems.Dialog_OK, "//button[@data-id='ok_id']" },
            { SeleniumSelectorItems.Entity_Header, "//button[@id='headerFieldsExpandButton']" },
            { SeleniumSelectorItems.Popup_TeachingBubble_CloseButton, "//button[contains(@class, 'ms-TeachingBubble-closebutton')]/span" }
        };

        public By GetXPathSeleniumSelector(SeleniumSelectorItems itemName)
        {
            return By.XPath(_selectors[itemName]);
        }

        public By GetXPathSeleniumSelector(SeleniumSelectorItems itemName, string nameReplacement)
        {
            return By.XPath(_selectors[itemName].Replace("[NAME]", nameReplacement));
        }
    }
}
