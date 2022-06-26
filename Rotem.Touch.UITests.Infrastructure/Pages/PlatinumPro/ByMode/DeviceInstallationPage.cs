using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Rotem.Touch.UITests.Infrastructure.Helpers;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Pages.PlatinumPro.ByMode
{
    public class DeviceInstallationPage<T> : AccordionTablePage<T>, IErrorMessagePage where T : class, IMetadataDependentPageObject, new()
    {
        private readonly string _dataFieldName;
        private readonly string _deviceColumn;
        private readonly List<List<string>> _state;
        public DeviceInstallationPage() { }
        public DeviceInstallationPage(string dataFieldName)
        {
            _state = new List<List<string>>();
            _dataFieldName = dataFieldName;
            var underscoreIndex = _dataFieldName.IndexOf('_');
            _deviceColumn = _dataFieldName.Substring(underscoreIndex + 1, _dataFieldName.Length - (underscoreIndex + 1));
        }
        public int DeviceCount(Device device)
        {
            int deviceCount = 0;

            ExpandAll();
            for (int rowIndex = 0; rowIndex < Rows.Count(); rowIndex++)
            {
                var row = Rows.ElementAt(rowIndex); 
                string rowDevice = row.FindElement(By.CssSelector(string.Format("td select[data-field='{0}']", _dataFieldName))).Text;

                if (rowDevice == StringEnum.GetStringValue(device))
                {
                    deviceCount++;
                }
            }

            return deviceCount;
        }
        public int RelayDevicesCount()
        {
            int deviceCount = 0;

            ExpandAll();
            for (int rowIndex = 0; rowIndex < Rows.Count(); rowIndex++)
            {
                var row = Rows.ElementAt(rowIndex);
                string rowDevice = row.FindElement(By.CssSelector(string.Format("td select[data-field='{0}']", _dataFieldName))).Text;

                if (rowDevice != "None")
                {
                    deviceCount++;
                }
            }

            return deviceCount;
        }
        public void SaveState()
        {
            ExpandAll();
            _state.Clear();
            for (int rowIndex = 0; rowIndex < Rows.Count(); rowIndex++)
            {
                _state.Add(TableHeader.FlatHeaderStructure.Select(header => GetCellCurrentValue(header.Name, rowIndex)).ToList());
            }
        }
        public void RollbackState()
        {
            var flatHeader = TableHeader.FlatHeaderStructure;
            for (int i = 0; i < _state.Count; i++)
            {
                for (int j = 0; j < flatHeader.Count; j++)
                {
                    EditCellContent(_state[i][j], flatHeader[j].Name, i);
                }
            }
            SaveChanges();
        }
        public int AddDevice(Device device, int count = 1, bool toSave = true, int rowIndex = 0)
        {
            
            try
            {
                ExpandAll();

                //Waits.Wait(3);//Gutman add

                //int rowIndex = 0;
                for (int deviceCount = 0; rowIndex < Rows.Count(); rowIndex++)
                {
                    var row = Rows.ElementAt(rowIndex);
                    string rowDevice = row.FindElement(By.CssSelector(string.Format("td select[data-field='{0}']", _dataFieldName))).Text;

                    if (rowDevice == StringEnum.GetStringValue(device))
                    {
                        deviceCount++;
                        if (deviceCount == count) break;
                    }
                    else if ((rowDevice == StringEnum.GetStringValue(Device.None)) || (rowDevice == StringEnum.GetStringValue(Device.NONE)))
                    {
                        EditCellContent(StringEnum.GetStringValue(device), _deviceColumn, rowIndex);
                        deviceCount++;
                        if (deviceCount == count) break;
                    }
                }

                if (toSave) SaveChanges();
                //Waits.Wait(3);

                return rowIndex;
            }
            catch (Exception ex)
            {
                if ((ex is InvalidOperationException) || (ex is NoSuchElementException))
                {
                    Trace.WriteLine("The device " + device + " can not be found." + device + " will not added");
                    //throw new Exception("The devices table can not be found. Devices can not to be added.");
                }
                throw;
            }
        }
        public int RemoveDevice(Device device, bool toSave = true)
        {
            return RemoveDevice(device, 0, toSave);
        }
        public int RemoveDevice(Device device, int fromRow, int count, bool toSave = true)
        {
            try
            {
                ExpandAll();

                int rowIndex = fromRow;
                for (var deviceCount = 0; rowIndex < Rows.Count(); rowIndex++)
                {
                    var row = Rows.ElementAt(rowIndex);
                    string rowDevice = row.FindElement(By.CssSelector(string.Format("td select[data-field='{0}']", _dataFieldName))).Text;

                    if (rowDevice == StringEnum.GetStringValue(device) || rowDevice.TrimEnd()== StringEnum.GetStringValue(device))
                    {
                        try
                        {
                            EditCellContent(StringEnum.GetStringValue(Device.None), _deviceColumn, rowIndex);
                        }
                        catch (NoSuchElementException)
                        {
                            EditCellContent(StringEnum.GetStringValue(Device.NONE), _deviceColumn, rowIndex);
                        }
                        deviceCount++;

                        if (deviceCount == count) break;
                    }
                }

                if (toSave) SaveChanges();
                Waits.Wait(4);

                return rowIndex;
            }
            catch (Exception ex)
            {
                if ((ex is InvalidOperationException) || (ex is NoSuchElementException))
                {
                    throw new Exception("The devices table can not be found. Devices can not to be removed.");
                }
                throw;
            }
        }
        public int RemoveDevice(Device device, int count, bool toSave = true)
        {
            return RemoveDevice(device, 0, count, toSave);
        }
        public bool RemoveDevices(Device[] devices, bool toSave = true)
        {
            try
            {
                ExpandAll();

                var devicesName = devices.Select(device => StringEnum.GetStringValue(device)).ToList();

                bool devicesRemoved = false;
                for (int rowIndex = 0; rowIndex < Rows.Count(); rowIndex++)
                {
                    var row = Rows.ElementAt(rowIndex);
                    string rowDevice = row.FindElement(By.CssSelector(string.Format("td select[data-field='{0}']", _dataFieldName))).Text.Trim();

                    if (devicesName.Contains(rowDevice))
                    {
                        EditCellContent(StringEnum.GetStringValue(Device.None), _deviceColumn, rowIndex);
                        devicesRemoved = true;
                    }
                }

                if(toSave) SaveChanges();
                Waits.Wait(4);

                return devicesRemoved;
            }
            catch (Exception ex)
            {
                if ((ex is InvalidOperationException) || (ex is NoSuchElementException))
                {
                    throw new Exception("The devices table can not be found. Devices can not to be removed.");
                }
                throw;
            }
        }
        public void AddDevices(Device[] devices)
        {
            try
            {
                ExpandAll();

                for (int rowIndex = 0, deviceIndex = 0; rowIndex < Rows.Count(); rowIndex++)
                {
                    var row = Rows.ElementAt(rowIndex);
                    string rowDevice = row.FindElement(By.CssSelector(string.Format("td select[data-field='{0}']", _dataFieldName))).Text;

                    if (devices.Any(device => rowDevice == StringEnum.GetStringValue(Device.None)))
                    {
                        EditCellContent(StringEnum.GetStringValue(devices[deviceIndex]), _deviceColumn, rowIndex);
                        deviceIndex++;

                        if (deviceIndex == devices.Length) break;
                    }
                }

                SaveChanges();
                Waits.Wait(4);
            }
            catch (Exception ex)
            {
                if ((ex is InvalidOperationException) || (ex is NoSuchElementException))
                {
                    throw new Exception("The devices table can not be found. Devices can not to be added.");
                }
                throw;
            }
        }
        public string ErrorMessage
        {
            get { return PageErrorMessageService.GetDisplayedErrorMessage(); }
        }
        public void ApproveErrorMessage()
        {
            PageErrorMessageService.ApproveErrorMessage();
        }
        public bool IsErrorMessageDisplayed()
        {
            return PageErrorMessageService.IsErrorMessageDisplayed();
        }
    }
}
