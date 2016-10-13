﻿// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : SymbolValue.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:13
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Magicodes.ECharts.CommonDefinitions;
using Magicodes.ECharts.JsonConverter;

namespace Magicodes.ECharts.ValueTypes
{
    /// <summary>
    ///     标记的图形
    /// </summary>
    [JsonConverter(typeof(ValueConverter<Symbols>))]
    public class SymbolValue : ISymbolValue, IValue<Symbols>
    {
        public SymbolValue(Symbols value)
        {
            Value = value;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public Symbols Value { get; set; }
    }
}