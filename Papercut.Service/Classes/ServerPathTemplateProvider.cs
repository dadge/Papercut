﻿// Papercut
// 
// Copyright © 2008 - 2012 Ken Robertson
// Copyright © 2013 - 2014 Jaben Cargman
//  
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//  
// http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Papercut.Service.Classes
{
    using System.Collections.ObjectModel;
    using System.Linq;

    using Papercut.Core.Configuration;

    public class ServerPathTemplateProvider : IPathTemplatesProvider
    {
        public ServerPathTemplateProvider(PapercutServiceSettings serviceSettings)
        {
            PathTemplates =
                new ObservableCollection<string>(
                    serviceSettings.MessagePath.Split(new[] { ';' })
                        .Select(s => s.Trim())
                        .Where(s => !string.IsNullOrWhiteSpace(s)));
        }

        public ObservableCollection<string> PathTemplates { get; private set; }
    }
}