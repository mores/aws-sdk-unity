//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

/*
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the output of a <i>Query</i> operation.
    /// </summary>
    public partial class QueryResult : AmazonWebServiceResponse
    {
        private ConsumedCapacity _consumedCapacity;
        private int? _count;
        private List<Dictionary<string, AttributeValue>> _items = new List<Dictionary<string, AttributeValue>>();
        private Dictionary<string, AttributeValue> _lastEvaluatedKey = new Dictionary<string, AttributeValue>();
        private int? _scannedCount;

        /// <summary>
        /// Gets and sets the property ConsumedCapacity.
        /// </summary>
        public ConsumedCapacity ConsumedCapacity
        {
            get { return this._consumedCapacity; }
            set { this._consumedCapacity = value; }
        }

        // Check to see if ConsumedCapacity property is set
        internal bool IsSetConsumedCapacity()
        {
            return this._consumedCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of items in the response.
        /// </para>
        ///  
        /// <para>
        /// If you used a <i>QueryFilter</i> in the request, then <i>Count</i> is the number of
        /// items returned after the filter was applied, and <i>ScannedCount</i> is the number
        /// of matching items before&gt; the filter was applied.
        /// </para>
        ///  
        /// <para>
        /// If you did not use a filter in the request, then <i>Count</i> and <i>ScannedCount</i>
        /// are the same.
        /// </para>
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// An array of item attributes that match the query criteria. Each element in this array
        /// consists of an attribute name and the value for that attribute.
        /// </para>
        /// </summary>
        public List<Dictionary<string, AttributeValue>> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastEvaluatedKey. 
        /// <para>
        /// The primary key of the item where the operation stopped, inclusive of the previous
        /// result set. Use this value to start a new operation, excluding this value in the new
        /// request.
        /// </para>
        ///  
        /// <para>
        /// If <i>LastEvaluatedKey</i> is empty, then the "last page" of results has been processed
        /// and there is no more data to be retrieved.
        /// </para>
        ///  
        /// <para>
        /// If <i>LastEvaluatedKey</i> is not empty, it does not necessarily mean that there is
        /// more data in the result set. The only way to know when you have reached the end of
        /// the result set is when <i>LastEvaluatedKey</i> is empty.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> LastEvaluatedKey
        {
            get { return this._lastEvaluatedKey; }
            set { this._lastEvaluatedKey = value; }
        }

        // Check to see if LastEvaluatedKey property is set
        internal bool IsSetLastEvaluatedKey()
        {
            return this._lastEvaluatedKey != null && this._lastEvaluatedKey.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScannedCount. 
        /// <para>
        /// The number of items evaluated, before any <i>QueryFilter</i> is applied. A high <i>ScannedCount</i>
        /// value with few, or no, <i>Count</i> results indicates an inefficient <i>Query</i>
        /// operation. For more information, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html#Count">Count
        /// and ScannedCount</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you did not use a filter in the request, then <i>ScannedCount</i> is the same as
        /// <i>Count</i>.
        /// </para>
        /// </summary>
        public int ScannedCount
        {
            get { return this._scannedCount.GetValueOrDefault(); }
            set { this._scannedCount = value; }
        }

        // Check to see if ScannedCount property is set
        internal bool IsSetScannedCount()
        {
            return this._scannedCount.HasValue; 
        }

    }
}