namespace SilverZone.Domain.Impl.Data
{
    internal static class DataContext
    {
        internal delegate void ContextDelegate(SilverZoneEntities silverZoneEntities);

        /// <summary>
        /// Use direct delegate: e.g. "ctx => ... "
        /// </summary>
        /// <param name="contextDelegate"></param>
        internal static void UsingContext(ContextDelegate contextDelegate)
        {
            using (SilverZoneEntities silverZoneEntities = new SilverZoneEntities("SilverZone"))
            {
                contextDelegate.Invoke(silverZoneEntities);
                silverZoneEntities.SaveChanges();
            }
        }

    }
}
