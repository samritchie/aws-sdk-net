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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterPartition operation.
    /// Deregister a Partition
    /// </summary>
    public partial class DeregisterPartitionRequest : AmazonCloudHSMRequest
    {
        private string _partitionArn;

        /// <summary>
        /// Gets and sets the property PartitionArn.
        /// </summary>
        public string PartitionArn
        {
            get { return this._partitionArn; }
            set { this._partitionArn = value; }
        }

        // Check to see if PartitionArn property is set
        internal bool IsSetPartitionArn()
        {
            return this._partitionArn != null;
        }

    }
}