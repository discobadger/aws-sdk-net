/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the GetStatistics operation.
    /// Gets statistics about things that match the specified query.
    /// </summary>
    public partial class GetStatisticsRequest : AmazonIoTRequest
    {
        private string _aggregationField;
        private string _indexName;
        private string _queryString;
        private string _queryVersion;

        /// <summary>
        /// Gets and sets the property AggregationField. 
        /// <para>
        /// The aggregation field name. Currently not supported.
        /// </para>
        /// </summary>
        public string AggregationField
        {
            get { return this._aggregationField; }
            set { this._aggregationField = value; }
        }

        // Check to see if AggregationField property is set
        internal bool IsSetAggregationField()
        {
            return this._aggregationField != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index to search. The default value is <code>AWS_Things</code>.
        /// </para>
        /// </summary>
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query used to search. You can specify "*" for the query string to get the count
        /// of all indexed things in your AWS account.
        /// </para>
        /// </summary>
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property QueryVersion. 
        /// <para>
        /// The version of the query used to search.
        /// </para>
        /// </summary>
        public string QueryVersion
        {
            get { return this._queryVersion; }
            set { this._queryVersion = value; }
        }

        // Check to see if QueryVersion property is set
        internal bool IsSetQueryVersion()
        {
            return this._queryVersion != null;
        }

    }
}