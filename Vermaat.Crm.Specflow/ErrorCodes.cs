﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vermaat.Crm.Specflow
{
    public class ErrorCodes
    {
        private readonly Dictionary<int, string> _errorMessages;

        public ErrorCodes()
        {
            _errorMessages = new Dictionary<int, string>();
            FillDictionary();
        }

        private void FillDictionary()
        {
            _errorMessages.Add(Constants.ErrorCodes.ERRORMESSAGE_NOT_FOUND, "Errormessage with ErrorCode {0} not found");
            _errorMessages.Add(Constants.ErrorCodes.FORMLOAD_SCRIPT_ERROR_ON_FORM, "Failed to load form due to a JavaScript error");
            _errorMessages.Add(Constants.ErrorCodes.BROWSER_OT_SUPPORTED_FOR_API_TEST, "Browser not supported for API only commands");
            _errorMessages.Add(Constants.ErrorCodes.N_N_RELATIONSHIP_NOT_FOUND, "No N:N relationship found between {0} and {1}");
            _errorMessages.Add(Constants.ErrorCodes.RECORD_NOT_FOUND, "Cannot find record {0} of type {1}");
            _errorMessages.Add(Constants.ErrorCodes.UNKNOWN_TAG, "Unknown tag. Use API, Chrome, Edge, Firefox or IE");
            _errorMessages.Add(Constants.ErrorCodes.API_NOT_SUPPORTED_FOR_BROWSER_ONLY_COMMANDS, "API not supported for Browser only commands");
            _errorMessages.Add(Constants.ErrorCodes.CURRENT_BUSINESS_PROCESS_STAGE_NOT_FOUND, "Current stage can't be found");
            _errorMessages.Add(Constants.ErrorCodes.BUSINESS_PROCESS_STAGE_NOT_IN_ACTIVE_PATH, "{0} isn't in the active path");
            _errorMessages.Add(Constants.ErrorCodes.BUSINESS_PROCESS_STAGE_CANNOT_BE_LAST, "Current stage be the last");
            _errorMessages.Add(Constants.ErrorCodes.LANGUAGECODE_MUST_BE_INTEGER, "AppSettings languagecode must be an integer i.e. 1033 for english");
            _errorMessages.Add(Constants.ErrorCodes.FORM_SAVE_FAILED, "Save failed. Detected unsaved changes after saving.");
            _errorMessages.Add(Constants.ErrorCodes.FORM_SAVE_TIMEOUT, "Save wasn't completed in {0} seconds");
            _errorMessages.Add(Constants.ErrorCodes.DUPLICATE_RECORD_DETECTED, "Duplicate found and not selected for save");
            _errorMessages.Add(Constants.ErrorCodes.FIELD_NOT_ON_FORM, "Field {0} can't be found on form");
            _errorMessages.Add(Constants.ErrorCodes.TWO_OPTION_FIELDS_CANT_BE_CLEARED, "Two option fields can't be cleared");
            _errorMessages.Add(Constants.ErrorCodes.MORE_COMMANDS_NOT_FOUND, "More commands button not found");
            _errorMessages.Add(Constants.ErrorCodes.UNKNOWN_FORM_NOTIFICATION_TYPE, "Unknown notification type. Current class: {0}");
            _errorMessages.Add(Constants.ErrorCodes.INVALID_FORM_STATE, "Invalid value for form state: {0}");
            _errorMessages.Add(Constants.ErrorCodes.APP_SETTINGS_REQUIRED, "AppSetting {0} is required");
            _errorMessages.Add(Constants.ErrorCodes.LABEL_NOT_TRANSLATED, "Label {0} doesn't have a translation for language {1}");
            _errorMessages.Add(Constants.ErrorCodes.ATTRIBUTE_DOESNT_EXIST, "Attribute {0} not found for entity {1}");
            _errorMessages.Add(Constants.ErrorCodes.LOOKUP_NOT_FOUND, "Lookup named {0} was not found. Queried entities: {1}");
            _errorMessages.Add(Constants.ErrorCodes.OPTION_NOT_FOUND, "Field {0} doesn't have option {1}");
            _errorMessages.Add(Constants.ErrorCodes.CANT_START_BROWSER_FOR_API_TESTS, "Cannot start the browser if the target is API");
            _errorMessages.Add(Constants.ErrorCodes.FORM_LOAD_TIMEOUT, "CRM Record is Unavailable or not finished loading. Timeout Exceeded");
            _errorMessages.Add(Constants.ErrorCodes.UNABLE_TO_LOGIN, "Failed to login. Error: {0}");
            _errorMessages.Add(Constants.ErrorCodes.FORM_NOT_FOUND, "Form {0} of entity {1} wasn't found");
        }

        public string GetErrorMessage(int errorCode, params object[] formatArgs)
        {
            Logger.WriteLine($"Getting error message for errorcode {errorCode}");
            if (!_errorMessages.ContainsKey(errorCode))
                return string.Format(_errorMessages[Constants.ErrorCodes.ERRORMESSAGE_NOT_FOUND], errorCode);

            return string.Format(_errorMessages[errorCode], formatArgs);
        }

        public void ChangeErrorMessage(int errorCode, string errorMessage)
        {
            _errorMessages[errorCode] = errorMessage;
        }
    }
}