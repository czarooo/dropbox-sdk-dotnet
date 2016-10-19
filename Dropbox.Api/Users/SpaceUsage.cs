// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Information about a user's space usage and quota.</para>
    /// </summary>
    public class SpaceUsage
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SpaceUsage> Encoder = new SpaceUsageEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SpaceUsage> Decoder = new SpaceUsageDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SpaceUsage" /> class.</para>
        /// </summary>
        /// <param name="used">The user's total space usage (bytes).</param>
        /// <param name="allocation">The user's space allocation.</param>
        public SpaceUsage(ulong used,
                          SpaceAllocation allocation)
        {
            if (allocation == null)
            {
                throw new sys.ArgumentNullException("allocation");
            }

            this.Used = used;
            this.Allocation = allocation;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SpaceUsage" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public SpaceUsage()
        {
        }

        /// <summary>
        /// <para>The user's total space usage (bytes).</para>
        /// </summary>
        public ulong Used { get; protected set; }

        /// <summary>
        /// <para>The user's space allocation.</para>
        /// </summary>
        public SpaceAllocation Allocation { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SpaceUsage" />.</para>
        /// </summary>
        private class SpaceUsageEncoder : enc.StructEncoder<SpaceUsage>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SpaceUsage value, enc.IJsonWriter writer)
            {
                WriteProperty("used", value.Used, writer, enc.UInt64Encoder.Instance);
                WriteProperty("allocation", value.Allocation, writer, Dropbox.Api.Users.SpaceAllocation.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SpaceUsage" />.</para>
        /// </summary>
        private class SpaceUsageDecoder : enc.StructDecoder<SpaceUsage>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SpaceUsage" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SpaceUsage Create()
            {
                return new SpaceUsage();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SpaceUsage value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "used":
                        value.Used = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    case "allocation":
                        value.Allocation = Dropbox.Api.Users.SpaceAllocation.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}