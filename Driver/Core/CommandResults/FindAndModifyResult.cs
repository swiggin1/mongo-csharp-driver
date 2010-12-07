﻿/* Copyright 2010 10gen Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace MongoDB.Driver {
    [Serializable]
    public class FindAndModifyResult : CommandResult {
        #region constructors
        public FindAndModifyResult() {
        }
        #endregion

        #region public properties
        public BsonDocument ModifiedDocument {
            get { return response["value"].AsBsonDocument; }
        }
        #endregion

        #region public methods
        public T GetModifiedDocument<T>() {
            return BsonSerializer.Deserialize<T>(ModifiedDocument.ToBson());
        }
        #endregion
    }
}
