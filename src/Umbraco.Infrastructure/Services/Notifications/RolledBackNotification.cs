// Copyright (c) Umbraco.
// See LICENSE for more details.

using Umbraco.Cms.Core.Events;

namespace Umbraco.Cms.Infrastructure.Services.Notifications
{
    public sealed class RolledBackNotification<T> : ObjectNotification<T> where T : class
    {
        public RolledBackNotification(T target, EventMessages messages) : base(target, messages)
        {
        }

        public T Entity => Target;
    }
}
