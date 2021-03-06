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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class DescribeDataSetMessageResponseUnmarshaller
    {
        public static DescribeDataSetMessageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataSetMessageResponse describeDataSetMessageResponse = new DescribeDataSetMessageResponse();

			describeDataSetMessageResponse.HttpResponse = context.HttpResponse;
			describeDataSetMessageResponse.RequestId = context.StringValue("DescribeDataSetMessage.RequestId");
			describeDataSetMessageResponse.Code = context.StringValue("DescribeDataSetMessage.Code");
			describeDataSetMessageResponse.Message = context.StringValue("DescribeDataSetMessage.Message");

			List<DescribeDataSetMessageResponse.DescribeDataSetMessage_ResultItem> describeDataSetMessageResponse_result = new List<DescribeDataSetMessageResponse.DescribeDataSetMessage_ResultItem>();
			for (int i = 0; i < context.Length("DescribeDataSetMessage.Result.Length"); i++) {
				DescribeDataSetMessageResponse.DescribeDataSetMessage_ResultItem resultItem = new DescribeDataSetMessageResponse.DescribeDataSetMessage_ResultItem();
				resultItem.Message = context.StringValue("DescribeDataSetMessage.Result["+ i +"].Message");
				resultItem.ErrorLevel = context.StringValue("DescribeDataSetMessage.Result["+ i +"].ErrorLevel");
				resultItem.ErrorType = context.StringValue("DescribeDataSetMessage.Result["+ i +"].ErrorType");
				resultItem.Timestamp = context.StringValue("DescribeDataSetMessage.Result["+ i +"].Timestamp");

				describeDataSetMessageResponse_result.Add(resultItem);
			}
			describeDataSetMessageResponse.Result = describeDataSetMessageResponse_result;
        
			return describeDataSetMessageResponse;
        }
    }
}
