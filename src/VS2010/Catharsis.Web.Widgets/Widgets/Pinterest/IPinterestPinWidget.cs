﻿using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Pinterest embedded pin widget.</para>
  ///   <para>Requires Pinterest scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://business.pinterest.com/widget-builder/#do_embed_pin"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Pinterest(IWidgetsScriptsRenderer)"/>
  public interface IPinterestPinWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Unique identifier of Pinterest Pin.</para>
    /// </summary>
    /// <param name="id">Identifier of pin.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IPinterestPinWidget Id(string id);

    /// <summary>
    ///   <para>Unique identifier of Pinterest Pin.</para>
    /// </summary>
    /// <returns>Identifier of pin.</returns>
    string Id();
  }
}