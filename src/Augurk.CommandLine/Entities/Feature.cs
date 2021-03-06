﻿/*
 Copyright 2017, Augurk
 
 Licensed under the Apache License, Version 2.0 (the "License");
 you may not use this file except in compliance with the License.
 You may obtain a copy of the License at
 
 http://www.apache.org/licenses/LICENSE-2.0
 
 Unless required by applicable law or agreed to in writing, software
 distributed under the License is distributed on an "AS IS" BASIS,
 WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 See the License for the specific language governing permissions and
 limitations under the License.
*/

using System.Collections.Generic;

namespace Augurk.CommandLine.Entities
{
    /// <summary>
    /// Represents a feature
    /// </summary>
    public class Feature
    {
        /// <summary>
        /// Gets or sets the title of the feature.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of this feature.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the tags of this feature.
        /// </summary>
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the scenarios of this feature.
        /// </summary>
        public IEnumerable<Scenario> Scenarios { get; set; }

        /// <summary>
        /// Gets or sets the background of this feature.
        /// </summary>
        public Background Background { get; set; }

        /// <summary>
        /// Gets or sets the filename of the source file that contains this feature.
        /// </summary>
        public string SourceFilename { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="SourceLocation"/> that identifies where the feature is defined in the <see cref="SourceFilename"/>.
        /// </summary>
        public SourceLocation Location { get; set; }
    }
}
