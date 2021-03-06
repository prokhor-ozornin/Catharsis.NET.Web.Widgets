﻿using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Pinterest embedded pin widget.</para>
  ///   <para>Requires Pinterest scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://business.pinterest.com/widget-builder/#do_embed_pin"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Pinterest(IWidgetsScriptsRenderer)"/>
  public sealed class PinterestPinWidget : HtmlWidget, IPinterestPinWidget
  {
    private string id;

    /// <summary>
    ///   <para>Unique identifier of Pinterest Pin.</para>
    /// </summary>
    /// <param name="id">Identifier of pin.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IPinterestPinWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Unique identifier of Pinterest Pin.</para>
    /// </summary>
    /// <returns>Identifier of pin.</returns>
    public string Id()
    {
      return this.id;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Id().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("a")
        .Attribute("data-pin-do", "embedPin")
        .Attribute("href", "http://www.pinterest.com/pin/{0}".FormatSelf(this.Id()))
        .ToString();
    }
  }
}