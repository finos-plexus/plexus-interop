/**
 * Copyright 2017-2018 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
// <auto-generated>
// 	Generated by the Plexus Interop compiler.  DO NOT EDIT!
// 	source: interop\app_launcher_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code
namespace Plexus.Interop.Apps.Internal.Generated {
	
	using System;
	using global::Plexus;
	using global::Plexus.Channels;
	using global::Plexus.Interop;
	using global::System.Threading.Tasks;
					
	internal static partial class AppLauncherService {
		
		public const string Id = "interop.AppLauncherService";			
		public const string LaunchMethodId = "Launch";
		
		public static readonly AppLauncherService.Descriptor DefaultDescriptor = CreateDescriptor();
		
		public static AppLauncherService.Descriptor CreateDescriptor() {
			return new AppLauncherService.Descriptor();
		} 
		
		public static AppLauncherService.Descriptor CreateDescriptor(string alias) {
			return new AppLauncherService.Descriptor(alias);
		}				
	
		public partial interface ILaunchProxy {
			IUnaryMethodCall<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse> Launch(global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest request);
		}
		
		public partial interface ILaunchImpl {
			Task<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse> Launch(global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest request, MethodCallContext context);
		}
		
		public sealed partial class Descriptor {
		
			public UnaryMethod<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest, global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse> LaunchMethod {get; private set; }
			
			public Descriptor() {				
				LaunchMethod = Method.Unary<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest, global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse>(Id, LaunchMethodId);
			}
		
			public Descriptor(string alias) {
				LaunchMethod = Method.Unary<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest, global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse>(Id, alias, LaunchMethodId);
			}
		}
	}
					
}
#endregion Designer generated code
