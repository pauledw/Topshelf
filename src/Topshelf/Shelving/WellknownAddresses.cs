﻿// Copyright 2007-2008 The Apache Software Foundation.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Topshelf.Shelving
{
    using System;
    using System.Diagnostics;

    public static class WellknownAddresses
    {
        public static Uri CurrentShelfAddress
        {
            get { return new Uri("net.pipe://localhost/topshelf-{0}-{1}".FormatWith(GetFolder(), GetPid())); }
        }

        public static Uri HostAddress
        {
            get { return new Uri("net.pipe://localhost/topshelf-host-{0}".FormatWith(GetPid())); }
        }

        public static Uri GetShelfAddress(AppDomain appDomain)
        {
            return new Uri("net.pipe://localhost/topshelf-{0}-{1}".FormatWith(appDomain.FriendlyName, GetPid()));
        }

        public static int GetPid()
        {
            return Process.GetCurrentProcess().Id;
        }

        public static string GetFolder()
        {
            return AppDomain.CurrentDomain.FriendlyName;
        }
    }
}