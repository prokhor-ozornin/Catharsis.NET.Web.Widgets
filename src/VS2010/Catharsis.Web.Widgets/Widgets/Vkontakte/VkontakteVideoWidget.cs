﻿using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded VKontakte video on web page.</para>
  /// </summary>
  public class VkontakteVideoWidget : HtmlWidget, IVkontakteVideoWidget
  {
    private string id;
    private string width;
    private string height;
    private bool hd;
    private string user;
    private string hash;

    /// <summary>
    ///   <para>Hash code of video.</para>
    /// </summary>
    /// <param name="hash">Video's hash code.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="hash"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="hash"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteVideoWidget Hash(string hash)
    {
      Assertion.NotEmpty(hash);

      this.hash = hash;
      return this;
    }

    /// <summary>
    ///   <para>Hash code of video.</para>
    /// </summary>
    /// <returns>Video's hash code.</returns>
    public string Hash()
    {
      return this.hash;
    }

    /// <summary>
    ///   <para>Whether to play video in High Definition format. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to use HD quality format, <c>false</c> to use standard quality.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteVideoWidget Hd(bool enabled)
    {
      this.hd = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to play video in High Definition format. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to use HD quality format, <c>false</c> to use standard quality.</returns>
    public bool Hd()
    {
      return this.hd;
    }

    /// <summary>
    ///   <para>Height of video control.</para>
    /// </summary>
    /// <param name="height">Height of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVkontakteVideoWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Height of video control.</para>
    /// </summary>
    /// <returns>Height of video.</returns>
    public string Height()
    {
      return this.height;
    }

    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <param name="id">Identifier of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVkontakteVideoWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <returns>Identifier of video.</returns>
    public string Id()
    {
      return this.id;
    }

    /// <summary>
    ///   <para>Account identifier of video's uploader.</para>
    /// </summary>
    /// <param name="user">User's account.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="user"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="user"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteVideoWidget User(string user)
    {
      Assertion.NotEmpty(user);

      this.user = user;
      return this;
    }

    /// <summary>
    ///   <para>Account identifier of video's uploader.</para>
    /// </summary>
    /// <returns>User's account.</returns>
    public string User()
    {
      return this.user;
    }

    /// <summary>
    ///   <para>Width of video control.</para>
    /// </summary>
    /// <param name="width">Width of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVkontakteVideoWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Width of video control.</para>
    /// </summary>
    /// <returns>Width of video.</returns>
    public string Width()
    {
      return this.width;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Id().IsEmpty() || this.User().IsEmpty() || this.Hash().IsEmpty() || this.Width().IsEmpty() || this.Height().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("iframe")
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)
        .Attribute("width", this.Width())
        .Attribute("height", this.Height())
        .Attribute("src", "http://vk.com/video_ext.php?oid={1}&id={0}&hash={2}&hd={3}".FormatSelf(this.Id(), this.User(), this.Hash(), this.Hd() ? 1 : 0))
        .ToString();
    }
  }
}