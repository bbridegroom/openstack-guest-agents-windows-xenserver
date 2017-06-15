﻿// Copyright 2011 OpenStack LLC.
// All Rights Reserved.
//
//    Licensed under the Apache License, Version 2.0 (the "License"); you may
//    not use this file except in compliance with the License. You may obtain
//    a copy of the License at
//
//         http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
//    WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
//    License for the specific language governing permissions and limitations
//    under the License.

using System.Text;
using Rackspace.Cloud.Server.Common.Configuration;

namespace Rackspace.Cloud.Server.Agent {
    public static class Constants {
        public const string XenToolsPath = @"C:\Program Files\Citrix\XenTools";
        public const string XenClientPath = XenToolsPath + @"\xenstore_client.exe";
        public const string KmsActivationVbsPath = @"c:\windows\system32\slmgr.vbs";


        public const string RackspaceRegKey = @"SOFTWARE\Rackspace";
        public const string CloudAutomationSysPrepRegKey = "cloud-automation";
        public const string CloudAutomationKMSActivateRegKey = "cloud-automation-run";
        public const string XenToolsUpdateSignalKey = "xentools-update-signal";

        public const string DeployCompleteCmdPath = @"c:\windows\setup\scripts\deploycomplete.cmd";
        public const string CloudAutomationCmdPath = @"c:\cloud-automation\bootstrap.cmd";
        public const string CloudAutomationBatPath = @"c:\cloud-automation\bootstrap.bat";

        public const string ReadOnlyDataConfigBase = "vm-data";
        public const string WritableDataHostBase = "data/host";
        public const string WritableDataGuestBase = "data/guest";
        public const string NetworkingBase = "networking";
        public const string MetadataBase = "user-metadata";
        public const string ProviderDataBase = "provider_data";
        public const string Provider = "provider";
        public const string Roles = "roles";
        public const string Region = "region";
        public const string IpWhiteList = "ip_whitelist";

        public const string SoftwareFirewallRuleName = "RS_FIREWALL_RULE";

        public const string SuccessfulKeyInit = "D0";

        public const string DiffieHellmanPrime = "162259276829213363391578010288127";
        public const string DiffieHellanGenerator = "5";

        public static string Combine(params string[] paths) {
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < paths.Length; i++) {
                stringBuilder.Append(paths[i]);
                if (i != paths.Length - 1)
                    stringBuilder.Append("/");
            }

            return stringBuilder.ToString();
        }

        public static readonly string XenToolsReleasePackage = SvcConfiguration.AgentVersionUpdatesPath + "xensetup.exe.zip";
        public static readonly string XenToolsUnzipPath = SvcConfiguration.AgentVersionUpdatesPath + "xentools";
        public static readonly string XenToolsSetupExecutablePath = XenToolsUnzipPath + @"\xensetup.exe";
        public static readonly string XenToolsSetupScriptPath = XenToolsUnzipPath + @"\install.bat";

        public static readonly string UpdaterUnzipPath = SvcConfiguration.AgentVersionUpdatesPath + "updater";
        public static readonly string UpdaterBackupPath = SvcConfiguration.AgentVersionUpdatesPath + "current_updater";
        public static readonly string UpdaterPath = @"C:\Program Files\Rackspace\Cloud Servers\AgentUpdater";
        public static readonly string UpdaterReleasePackageName = "UpdateService.zip";
        public static readonly string UpdaterEmbeddedReleasePackagePath = "Rackspace.Cloud.Server.Agent.UpdaterFiles.UpdateService.zip";
        public static readonly string UpdaterReleasePackage = SvcConfiguration.AgentVersionUpdatesPath + UpdaterReleasePackageName;
        public static readonly string XenToolsRegPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Citrix\XenTools";

    }
}
