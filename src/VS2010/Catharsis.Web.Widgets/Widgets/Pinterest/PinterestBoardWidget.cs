﻿using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Pinterest Board widget with board's latest pins.</para>
  ///   <para>Requires Pinterest scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://business.pinterest.com/widget-builder/#do_embed_board"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Pinterest(IWidgetsScriptsRenderer)"/>
  public sealed class PinterestBoardWidget : HtmlWidget, IPinterestBoardWidget
  {
    private string account;
    private string height;
    private string width;
    private string id;
    private string image;

    /// <summary>
    ///   <para>Pinterest user account.</para>
    /// </summary>
    /// <param name="account">Account name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IPinterestBoardWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Pinterest user account.</para>
    /// </summary>
    /// <returns>Account name.</returns>
    public string Account()
    {
      return this.account;
    }

    /// <summary>
    ///   <para>Total height of board in pixels.</para>
    /// </summary>
    /// <param name="height">Board's height.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>Min: 60; leave blank for 175.</remarks>
    public IPinterestBoardWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Total height of board in pixels.</para>
    /// </summary>
    /// <returns>Board's height.</returns>
    public string Height()
    {
      return this.height;
    }

    /// <summary>
    ///   <para>Total width of board in pixels.</para>
    /// </summary>
    /// <param name="width">Board's width.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>Min: 130; leave blank for auto.</remarks>
    public IPinterestBoardWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Total width of board in pixels.</para>
    /// </summary>
    /// <returns>Board's width.</returns>
    public string Width()
    {
      return this.width;
    }

    /// <summary>
    ///   <para>Identifier of account's board.</para>
    /// </summary>
    /// <param name="id">Board's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IPinterestBoardWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of account's board.</para>
    /// </summary>
    /// <returns>Board's identifier.</returns>
    public string Id()
    {
      return this.id;
    }

    /// <summary>
    ///   <para>Width of board's image in pixels.</para>
    /// </summary>
    /// <param name="width">Board's image width.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>Min: 60; leave blank for 92.</remarks>
    public IPinterestBoardWidget Image(string width)
    {
      Assertion.NotEmpty(width);

      this.image = width;
      return this;
    }

    /// <summary>
    ///   <para>Width of board's image in pixels.</para>
    /// </summary>
    /// <returns>Board's image width.</returns>
    public string Image()
    {
      return this.image;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Account().IsEmpty() || this.Id().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("a")
        .Attribute("data-pin-do", "embedBoard")
        .Attribute("href", "http://www.pinterest.com/{0}/{1}".FormatSelf(this.Account(), this.Id()))
        .Attribute("data-pin-scale-width", this.Image())
        .Attribute("data-pin-scale-height", this.Height())
        .Attribute("data-pin-board-width", this.Width())
        .ToString();
    }
  }
}