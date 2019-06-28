/**
 * banner数据
 */ 
function getBannerData(){
  var arr = ['../../images/banner1.jpg', 
              '../../images/banner1.jpg', 
              '../../images/banner1.jpg', 
              '../../images/banner1.jpg']
    return arr
}
/*
 * 首页 navnav 数据
 */ 
function getIndexNavData(){
    var arr = [
            {
                id:1,
                icon:"../../images/nav_1.png",
                title:"推荐"
            },
            {
                id:2,
                icon:"../../images/nav_1.png",
                title:"项目1"
            },
            {
                id:3,
                icon:"../../images/nav_1.png",
                title:"项目2"
            },
            {
                id:4,
                icon:"../../images/nav_1.png",
                title:"项目3"
            },
            {
                id:5,
                icon:"../../images/nav_1.png",
                title:"项目4"
            }
        ]
    return arr
}
/*
 * 首页 对应 标签 数据项
 */ 
function getIndexNavSectionData(){
    var arr = [
                [
                    {
                        
                        subject:"主题1",
                        coverpath:"../../images/zanwu1.png",
                        price:'¥198',
                        message:'摘要！'
                    },
                    {
                        
                        subject:"主题2",
                        coverpath:"../../images/zanwu1.png",
                        price:'¥1888',
                        message:'摘要！'
                    },
                    {
                        
                        subject:"主题3",
                        coverpath:"../../images/zanwu1.png",
                        price:'¥1588',
                        message:'摘要！'
                    },
                    {
                        
                        subject:"主题4",
                      coverpath:"../../images/zanwu1.png",
                        price:'¥198',
                        message:'摘要'
                    },
                    {
                        
                        subject:" 主题5",
                        coverpath:"../../images/zanwu1.png",
                        price:'¥198',
                        message:'摘要'
                    }
                ],
                [
                    {
                        artype:'nails',
                        subject:"主题1",
                    coverpath:"../../images/zanwu1.png",
                        price:'¥198',
                        message:'摘要'
                    }
                ],
                [
                    {
                        artype:'beauty',
                        subject:"主题",
                    coverpath:"../../images/zanwu1.png",
                        price:'¥1588',
                        message:'摘要'
                    },
                    {
                        artype:'beauty',
                        subject:" 主题",
                      coverpath:"../../images/zanwu1.png",
                        price:'¥198',
                        message:'摘要'
                    }
                ],
                [
                    
                    {
                        artype:'hair',
                        subject:"主题",
                    coverpath:"../../images/zanwu1.png",
                        price:'¥1588',
                        message:'摘要'
                    }
                ],
                [
                    {
                        artype:'eyelash',
                        subject:"主题",
                    coverpath:"../../images/zanwu1.png",
                        price:'¥1888',
                        message:'摘要'
                    }
                ] 
            ]
    return arr
}
/**
 * 活动数据 数据
 * */ 
function getSalonData(){
    var arr = [
                {
                  avatar:"../../images/zanwu1.png",
                  nickname:'张xx',
                  price:'¥500',
                  message:'xxxxxxxxxxxxxx',
                  detail: 'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx',
                  addrs: 'xxxxxxxxxxxxxxx',
                  type: 'xxxxx'
                },
                {
                  avatar:"../../images/zanwu1.png",
                  nickname:'包xx',
                  price:'¥800',
                  message:'xxxxxxxxxxx',
                  detail: 'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx',
                  addrs: 'xxxxxxxxxxxxxxx',
                  type: 'xxxxx'
                },
                {
                  avatar:"../../images/zanwu1.png",
                  nickname:'xxx',
                  price:'¥600',
                  message:'xxxxxxxxxxx',
                  detail: 'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx',
                  addrs: 'xxxxxxxxxxxxxxx,xxxxxxxxxxx',
                  type: 'xxxxx,xxxx'
                },
                {
                  avatar:"../../images/zanwu1.png",
                  nickname:'黄xx',
                  price:'¥800',
                  message:'xxxxxxxxxxx',
                  detail: 'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx',
                  addrs: 'xxxxxxxxxxxxxxx,xxxxxxxxxxx',
                  type: 'xxxxx,xxxx'
                }
            ]
    return arr
}

/**
 * 选择器 数据
 */ 
function getPickerData(){
    var arr =[
        {
            name:'姓名1',
            phone:'13812314563',
            province:'福建省',
            city:'厦门',
            addr:'思明区A座8011'
        },
        {
            name:'姓名2',
            phone:'13812314563',
            province:'福建省',
            city:'厦门',
            addr:'海沧区A座4020'
        }
    ]
    return  arr
}
/**
 * 查询 地址
 * */ 
var user_data = userData()
function searchAddrFromAddrs(addrid){
    var result
    for(let i=0;i<user_data.addrs.length;i++){
        var addr = user_data.addrs[i]
        console.log(addr)
        if(addr.addrid == addrid){
            result = addr
        }
    }
    return result || {}
}
/**
 * 用户数据
 * */ 
function userData(){
    var arr = {
                uid:'1',
                nickname:'yancy',
                name:'chen yancy',
                phone:'18250838909',
                avatar:'../../images/avatar.png',
                addrs:[
                   {
                        addrid:'1',
                        name:'姓名',
                        phone:'电话',
                        province:'省份',
                        city:'城市',
                        addr:'区域'
                    },
                    {
                        addrid:'2',
                        name:'姓名',
                        phone:'电话2',
                        province:'省份',
                        city:'城市',
                        addr:'地区'
                    } 
                ]
            }
    return arr
}
/**
 * 省
 * */ 
function provinceData(){
    var arr = [
        // {pid:1,pzip:'110000',pname:'北京市'},
        // {pid:2,pzip:'120000',pname:'天津市'}
        '请选择省份','福建省'
    ]
    return arr
}
/**
 * 市
 * */ 
function cityData(){
    var arr = [
        // {cid:1,czip:'110100',cname:'市辖区',pzip:'110000'},
        // {cid:2,czip:'120100',cname:'市辖区',pzip:'120000'}
        '请选择城市','福州市','厦门市','宁德市'
    ]
    return arr
}
/*
 * 对外暴露接口
 */ 
module.exports = {
  getBannerData : getBannerData,
  getIndexNavData : getIndexNavData,
  getIndexNavSectionData : getIndexNavSectionData,
  getPickerData : getPickerData,
  getSalonData: getSalonData,
  userData : userData,
  provinceData : provinceData,
  cityData : cityData,
  searchAddrFromAddrs : searchAddrFromAddrs

}