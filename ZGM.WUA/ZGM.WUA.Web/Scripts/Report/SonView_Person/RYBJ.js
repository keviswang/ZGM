﻿$(function () {
    SJLYFX.init();
});
//当页面改变大小的时候，重置菜单大小
document.body.onresize = function () {
    SJLYFX.resize();
}

var SJLYFX = {
    dataType: 0,
    apiconfig: "",
    init: function () { this.tabClick(); this.resize(); },
    resize: function () {
        var vh = document.body.clientHeight;
        var bh = $(".top_RYBJ").height();

        $(".content_1").css("height", (vh - bh) * 0.4);
        $(".content_2").css("height", (vh - bh) * 0.6);

        this.apiconfig = parent.parent.globalConfig.apiconfig;
        this.chartLoad();
    },
    tabClick: function () {
        $(".tab").each(function (i) {
            $(this).click(function () {
                if (i == 0) {
                    $(this).addClass("tab_left_selected").siblings().removeClass("tab_center_selected").removeClass("tab_right_selected");
                }
                else if (i == 1) {
                    $(this).addClass("tab_center_selected").siblings().removeClass("tab_left_selected").removeClass("tab_right_selected");
                }
                else if (i == 2) {
                    $(this).addClass("tab_right_selected").siblings().removeClass("tab_left_selected").removeClass("tab_center_selected");
                }
                SJLYFX.dataType = i ;
                SJLYFX.chartLoad();
            });
        })
    },
    chartLoad: function () {
       
        //myChart_2 = echarts.init(document.getElementById('bar_chartDiv'));
        //myChart_2.setOption(option2);
        $.ajax({
            type: "GET",
            async: true,
            url: this.apiconfig + "/api/TJReport/GetUnitAlarm",
            data: { DateType: SJLYFX.dataType },
            dataType: "json",
            success: function (result) {
                if (result != null) {
                    option.legend.data[0]="越界    " + result.OverBorderCount + "    " + result.OverBorderPercent;
                    option.legend.data[1]="离线    " + result.OverLineCount + "    " + result.OverLinePercent;
                    option.legend.data[2] = "停留    " + result.OverTimeCount + "    " + result.OverTimePercent;

                    option.series[0].data[0] = { value: result.OverBorderCount, name: "越界    " + result.OverBorderCount + "    " + result.OverBorderPercent };
                    option.series[0].data[1] = { value: result.OverLineCount, name: "离线    " + result.OverLineCount + "    " + result.OverLinePercent };
                    option.series[0].data[2] = { value: result.OverTimeCount, name: "停留    " + result.OverTimeCount + "    " + result.OverTimePercent };
                }
                myChart_1 = echarts.init(document.getElementById('pie_chartDiv'));
                myChart_1.setOption(option);
            },
            error: function (errorMsg) {
                console.log(errorMsg);
            }
        });

        $.ajax({
            type: "GET",
            async: true,
            url: this.apiconfig + "/api/TJReport/GetUnitProwled",
            data: { DateType: SJLYFX.dataType },
            dataType: "json",
            success: function (result) {
                if (result != null && result.length > 0) {
                    for (var i = 0; i < result.length; i++) {
                        option2.xAxis[0].data[i] = result[i].UnitName;
                        //'越界报警', '离线报警', '停留报警'
                        option2.series[0].data[i] = result[i].OverBorderCount;
                        option2.series[1].data[i] = result[i].OverLineCount;
                        option2.series[2].data[i] = result[i].OverTimeCount;
                        myChart_2 = echarts.init(document.getElementById('bar_chartDiv'));
                        myChart_2.setOption(option2);
                    }
                }
            },
            error: function (errorMsg) {
                console.log(errorMsg);
            }
        });
    }
}

var myChart_1 = null;
option = {
    tooltip: {
        trigger: 'item',
    },
    legend: {
        orient: 'vertical',
        x: 'right',
        y: 'center',
        padding: [0, 350, 0, 0],
        selectedMode: true,
        itemGap: 25,
        textStyle: {
            fontFamily: 'Microsoft YaHei',
            fontSize: 16,
            color: '#ffffff',
            fontStyle: 'normal',
            fontWeight: 'normal',
        },
       
        data: []
        // {name: '越界    32条    32%'}, '离线    32条    32%', '停留    36条    36%'
    },
    color: ['#207cb7', '#81cf1e', '#f6c01b'],
    series: [
        {
            name: '报警类型',
            type: 'pie',
            radius:  '55%',
            center: ['30%', '48%'],
            itemStyle: {
                normal: {
                    label: {
                        textStyle: {
                            color: '#ffffff',
                            fontFamily: 'Microsoft YaHei',
                            fontSize: 16,
                            fontStyle: 'normal',
                            fontWeight: 'normal',
                        },
                        formatter: function (a, b, c) {
                            //return a.name.split(' ')[0];
                        }
                    }
                }
            },
            data: [
                // { value: 32, name: '越界    32条    32%' },
                //{ value: 32, name: '离线    32条    32%' },
                //{ value: 36, name: '停留    36条    36%' }
               
            ]
        }
    ]
};

var myChart_2 = null;
option2 = {
    tooltip: {
        trigger: 'axis',
        axisPointer: {
            lineStyle: {
                color: '#3cf5f3',
                width: 2
            }
        }
    },
    grid: {
        left: '1%',
        right: '4%',
        bottom: '0%',
        top: '20%',
        containLabel: true,
        backgroundColor: "transparent",
        borderColor: "transparent",
        show: true,
    },
    title:{
        show: true,
        zlevel: 0,
        z: 6,
        text: '人员报警情况',
        x: 'center',
        textStyle: {
            fontFamily: 'Microsoft YaHei',
            fontSize: 16,
            color: '#c6c7c6',
            fontStyle: 'normal',
            fontWeight: '600',
        },
    },
    legend: {
        selectedMode: true,
        show: true,
        textStyle: {
            fontFamily: 'Microsoft YaHei',
            fontSize: 12,
            color: '#c6c7c6',
            fontStyle: 'normal',
            fontWeight: 'normal',
        },
        x: 'right',
        padding: [0, 50, 0, 0],
        y: 'top',
        data: ['越界报警', '离线报警', '停留报警']
    },
    xAxis: [
        {
            type: 'category',
            name: '中队名',
            splitLine: {
                show: false
            },
            axisLabel: {
                textStyle: {
                    fontFamily: 'Microsoft YaHei',
                    fontSize: 14,
                    color: '#fff',
                },
            },
            axisTick: {
                lineStyle: {
                    color: '#32a1a2'
                }
            },
            axisLine: {
                lineStyle: {
                    color: '#32a1a2'
                }
            },
            data: []
            //'万达分队', '鄞南分队', '智慧分队', '长丰分队', '钟公庙分队', '机动分队', '中队部'
        }
    ],
    yAxis: [
        {
            type: 'value',
            name: '次数',
            splitLine: {
                show: true,
                lineStyle: {
                    color: '#3b4459',
                    type: 'dashed',
                    width: 0.5,
                    shadowColor: 'rgba(0,0,0,0)',
                    shadowBlur: 5,
                    shadowOffsetX: 3,
                    shadowOffsetY: 3,
                },
            },
            axisTick: {
                lineStyle: {
                    color: '#32a1a2'
                }
            },
            axisLine: {
                lineStyle: {
                    color: '#32a1a2'
                }
            },
            axisLabel: {
                textStyle: {
                    fontFamily: 'Microsoft YaHei',
                    fontSize: 14,
                    color: '#fff',
                }
            }
        }
    ],

    series: [
        {
            name: '越界报警',
            type: 'bar',
            itemStyle: {
                normal: {
                    color: "#697be6",
                    barBorderColor: '#697be6',
                    barBorderWidth: 5,
                    barBorderRadius: 2
                }
            },
            barWidth: 20,
            data: [
               
            ]
            // 420, 432, 301, 534, 390, 430,111

        },
        {
            name: '离线报警',
            type: 'bar',
            barWidth: 40,                   // 系列级个性化，柱形宽度
            itemStyle: {
                normal: {
                    color: "#ffff00",
                    barBorderColor: '#ff0000',
                    barBorderWidth: 5,
                    barBorderRadius: 2
                }
            },
            barWidth: 20,
            data: []
            //320, 232, 201, 234, 290, 130, 130
        },
        {
            name: '停留报警',
            type: 'bar',
            barWidth: 40,                   // 系列级个性化，柱形宽度
            itemStyle: {
                normal: {
                    color: "#ff0000",
                    barBorderColor: '#ff6347',
                    barBorderWidth: 5,
                    barBorderRadius: 2
                }
            },
            barWidth: 20,
            data: []
            //220, 232, 101, 234, 190, 330, 130
        }
    ]
};
