/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.digitalstore.Transform;
using Aliyun.Acs.digitalstore.Transform.V20200107;

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
    public class DisassociateSKUTagsRequest : RpcAcsRequest<DisassociateSKUTagsResponse>
    {
        public DisassociateSKUTagsRequest()
            : base("digitalstore", "2020-01-07", "DisassociateSKUTags", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<string> tagss = new List<string>(){ };

		private string businessUnitId;

		private string warehouseId;

		public List<string> Tagss
		{
			get
			{
				return tagss;
			}

			set
			{
				tagss = value;
				for (int i = 0; i < tagss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Tags." + (i + 1) , tagss[i]);
				}
			}
		}

		public string BusinessUnitId
		{
			get
			{
				return businessUnitId;
			}
			set	
			{
				businessUnitId = value;
				DictionaryUtil.Add(BodyParameters, "BusinessUnitId", value);
			}
		}

		public string WarehouseId
		{
			get
			{
				return warehouseId;
			}
			set	
			{
				warehouseId = value;
				DictionaryUtil.Add(BodyParameters, "WarehouseId", value);
			}
		}

        public override DisassociateSKUTagsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DisassociateSKUTagsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
