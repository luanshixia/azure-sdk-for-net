// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ResourceGroupsOperations.
    /// </summary>
    public static partial class ResourceGroupsOperationsExtensions
    {
            /// <summary>
            /// Checks whether a resource group exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to check. The name is case insensitive.
            /// </param>
            public static bool CheckExistence(this IResourceGroupsOperations operations, string resourceGroupName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IResourceGroupsOperations)s).CheckExistenceAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether a resource group exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to check. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<bool> CheckExistenceAsync(this IResourceGroupsOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CheckExistenceWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to create or update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a resource group.
            /// </param>
            public static ResourceGroup CreateOrUpdate(this IResourceGroupsOperations operations, string resourceGroupName, ResourceGroup parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IResourceGroupsOperations)s).CreateOrUpdateAsync(resourceGroupName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to create or update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update a resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ResourceGroup> CreateOrUpdateAsync(this IResourceGroupsOperations operations, string resourceGroupName, ResourceGroup parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a resource group.
            /// </summary>
            /// <remarks>
            /// When you delete a resource group, all of its resources are also deleted.
            /// Deleting a resource group deletes all of its template deployments and
            /// currently stored operations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to delete. The name is case insensitive.
            /// </param>
            public static void Delete(this IResourceGroupsOperations operations, string resourceGroupName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IResourceGroupsOperations)s).DeleteAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a resource group.
            /// </summary>
            /// <remarks>
            /// When you delete a resource group, all of its resources are also deleted.
            /// Deleting a resource group deletes all of its template deployments and
            /// currently stored operations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to delete. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IResourceGroupsOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            public static ResourceGroup Get(this IResourceGroupsOperations operations, string resourceGroupName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IResourceGroupsOperations)s).GetAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ResourceGroup> GetAsync(this IResourceGroupsOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a resource group.
            /// </summary>
            /// <remarks>
            /// Resource groups can be updated through a simple PATCH operation to a group
            /// address. The format of the request is the same as that for creating a
            /// resource group. If a field is unspecified, the current value is retained.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to update. The name is case insensitive.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update a resource group.
            /// </param>
            public static ResourceGroup Update(this IResourceGroupsOperations operations, string resourceGroupName, ResourceGroupPatchable parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IResourceGroupsOperations)s).UpdateAsync(resourceGroupName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a resource group.
            /// </summary>
            /// <remarks>
            /// Resource groups can be updated through a simple PATCH operation to a group
            /// address. The format of the request is the same as that for creating a
            /// resource group. If a field is unspecified, the current value is retained.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to update. The name is case insensitive.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update a resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ResourceGroup> UpdateAsync(this IResourceGroupsOperations operations, string resourceGroupName, ResourceGroupPatchable parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Captures the specified resource group as a template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to export as a template.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for exporting the template.
            /// </param>
            public static ResourceGroupExportResult ExportTemplate(this IResourceGroupsOperations operations, string resourceGroupName, ExportTemplateRequest parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IResourceGroupsOperations)s).ExportTemplateAsync(resourceGroupName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Captures the specified resource group as a template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to export as a template.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for exporting the template.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ResourceGroupExportResult> ExportTemplateAsync(this IResourceGroupsOperations operations, string resourceGroupName, ExportTemplateRequest parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ExportTemplateWithHttpMessagesAsync(resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the resource groups for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ResourceGroup> List(this IResourceGroupsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<ResourceGroupFilter> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ResourceGroupFilter>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IResourceGroupsOperations)s).ListAsync(odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the resource groups for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ResourceGroup>> ListAsync(this IResourceGroupsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<ResourceGroupFilter> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ResourceGroupFilter>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a resource group.
            /// </summary>
            /// <remarks>
            /// When you delete a resource group, all of its resources are also deleted.
            /// Deleting a resource group deletes all of its template deployments and
            /// currently stored operations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to delete. The name is case insensitive.
            /// </param>
            public static void BeginDelete(this IResourceGroupsOperations operations, string resourceGroupName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IResourceGroupsOperations)s).BeginDeleteAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a resource group.
            /// </summary>
            /// <remarks>
            /// When you delete a resource group, all of its resources are also deleted.
            /// Deleting a resource group deletes all of its template deployments and
            /// currently stored operations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to delete. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IResourceGroupsOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all the resource groups for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ResourceGroup> ListNext(this IResourceGroupsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IResourceGroupsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the resource groups for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ResourceGroup>> ListNextAsync(this IResourceGroupsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
