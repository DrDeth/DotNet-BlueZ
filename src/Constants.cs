﻿using System;

namespace HashtagChris.DotNetBlueZ
{
    public static class BluezConstants
    {
        public const string DbusService = "org.bluez";
        public const string AdapterInterface = "org.bluez.Adapter1";
        public const string DeviceInterface = "org.bluez.Device1";
        public const string GattServiceInterface = "org.bluez.GattService1";
        public const string GattCharacteristicInterface = "org.bluez.GattCharacteristic1";
    }

    public class GattConstants
    {
        // https://www.bluetooth.org/docman/handlers/downloaddoc.ashx?doc_id=244369
        public const string DeviceInformationServiceUUID = "0000180a-0000-1000-8000-00805f9b34fb";
        public const string ModelNameCharacteristicUUID = "00002a24-0000-1000-8000-00805f9b34fb";
        public const string ManufacturerNameCharacteristicUUID = "00002a29-0000-1000-8000-00805f9b34fb";

        // https://www.bluetooth.com/wp-content/uploads/Sitecore-Media-Library/Gatt/Xml/Services/org.bluetooth.service.battery_service.xml
        public const string BatteryServiceUUID = "0000180f-0000-1000-8000-00805f9b34fb";
        public const string BatteryLevelCharacteristicUUID = "00002a19-0000-1000-8000-00805f9b34fb";
    }
}
