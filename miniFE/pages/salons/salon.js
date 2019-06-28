/*technician.js*/

//获取应用实例
var app = getApp()
var fileData = require('../../utils/data.js')
var util = require('../../utils/util')

Page({
  // 页面初始数据
  data: {
    addrArray: util.replacePhone(fileData.userData().addrs, false),
    salonData: fileData.getSalonData(),
    casIndex: 0,
    addrIndex: 0

  },

  onLoad: function() {
    var that = this
    that.setData({
      list: that.data.salonData
    })
  },
  // 跳转至详情页
  navigateDetail: function(e) {
    wx.navigateTo({
      url: './salon_detail/salon_detail?artype=' + e.currentTarget.dataset.arid
    })
  },
  // 加载更多
  loadMore: function(e) {
    if (this.data.salonData.length === 0) return
    var that = this
    that.data.salonData = that.data.salonData.concat(that.data.salonData)
    that.setData({
      list: that.data.salonData,
    })
  },
  // 类别选择
  bindCasPickerChange: function(e) {
    this.setData({
      casIndex: e.detail.value
    })
  },
  // 地址选择
  bindAddrPickerChange: function(e) {
    this.setData({
      addrIndex: e.detail.value
    })
  }
})