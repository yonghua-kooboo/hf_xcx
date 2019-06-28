//index.js
//获取应用实例
var app = getApp()
var myData = require('../../utils/data')
var util = require('../../utils/util')

Page({
  // 页面初始数据
  data: {
    userData: myData.userData(),
    addrDate: util.replacePhone(myData.userData().addrs,true),
    list: [
      {
        img: '../../images/mine/sunburn@2x.png',
        title: '晒单',
        url: '../sunburn/sunburn'
      },
      {
        img: '../../images/mine/address@2x.png',
        title: '地址管理',
        url: '../address/address'
      },
      {
        img: '../../images/mine/wardrobe@2x.png',
        title: '皮肤测试',
        url: '../wardrobe/wardrobe'
      },
      {
        img: '../../images/mine/coupons@2x.png',
        title: '会员中心',
        url: '',
      },
      {
        img: '../../images/mine/coupons@2x.png',
        title: '优惠券',
        url: '',
      },
      {
        img: '../../images/mine/service@2x.png',
        title: '客服',
        url: 'contact'
      },
      {
        img: '../../images/mine/feedback@2x.png',
        title: '意见反馈',
        url: 'feedback'
      }
    ]
  },
  onShow() {
    this.setData({
      userInfo: app.globalData.userInfo
    })
  },
  // 地址编辑
  editAddr : function(e){
    wx.navigateTo({
      url:'./edit_addr/edit_addr?addrid='+e.currentTarget.dataset.addrid
    })
  }
})
