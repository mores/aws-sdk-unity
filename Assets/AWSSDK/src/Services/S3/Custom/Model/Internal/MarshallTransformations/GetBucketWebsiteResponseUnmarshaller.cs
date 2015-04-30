//
// Copyright 2014-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//
//
// Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
// You may not use this file except in compliance with the License.
// A copy of the License is located in the "license" file accompanying this file.
// See the License for the specific language governing permissions and limitations under the License.
//
//

using System;
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for GetBucketWebsite operation
    /// </summary>
    internal class GetBucketWebsiteResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            GetBucketWebsiteResponse response = new GetBucketWebsiteResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {                    
                    UnmarshallResult(context,response);                        
                    continue;
                }
            }
                 
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,GetBucketWebsiteResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;

            response.WebsiteConfiguration = new WebsiteConfiguration();
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("RedirectAllRequestsTo", targetDepth))
                    {
                        response.WebsiteConfiguration.RedirectAllRequestsTo = RoutingRuleRedirectUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("IndexDocument/Suffix", targetDepth))
                    {
                        response.WebsiteConfiguration.IndexDocumentSuffix = StringUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ErrorDocument/Key", targetDepth))
                    {
                        response.WebsiteConfiguration.ErrorDocument = StringUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("RoutingRule", targetDepth + 1))
                    {
                        response.WebsiteConfiguration.RoutingRules.Add(RoutingRuleUnmarshaller.Instance.Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
                            


            return;
        }

        private static GetBucketWebsiteResponseUnmarshaller _instance;

        public static GetBucketWebsiteResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketWebsiteResponseUnmarshaller();
                }
                return _instance;
            }
        }
    
    }
}
    