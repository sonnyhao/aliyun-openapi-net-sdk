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
using Aliyun.Acs.dg.Transform;
using Aliyun.Acs.dg.Transform.V20190327;

namespace Aliyun.Acs.dg.Model.V20190327
{
    public class DownloadGatewayProgramRequest : RpcAcsRequest<DownloadGatewayProgramResponse>
    {
        public DownloadGatewayProgramRequest()
            : base("dg", "2019-03-27", "DownloadGatewayProgram", "dg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dg.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string userOS;

		private string dgVersion;

		public string UserOS
		{
			get
			{
				return userOS;
			}
			set	
			{
				userOS = value;
				DictionaryUtil.Add(BodyParameters, "UserOS", value);
			}
		}

		public string DgVersion
		{
			get
			{
				return dgVersion;
			}
			set	
			{
				dgVersion = value;
				DictionaryUtil.Add(BodyParameters, "DgVersion", value);
			}
		}

        public override DownloadGatewayProgramResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DownloadGatewayProgramResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
