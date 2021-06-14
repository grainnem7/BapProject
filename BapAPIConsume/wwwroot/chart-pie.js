/**
 * ---------------------------------------
 * This demo was created using amCharts 4.
 *
 * For more information visit:
 * https://www.amcharts.com/
 *
 * Documentation is available at:
 * 
 * https://www.amcharts.com/download/https://www.amcharts.com/docs/v4/
 * ---------------------------------------
 */

/* Set theme(s) */
am4core.useTheme(am4themes_animated);

/* Create chart */
var chart = am4core.create("chartdiv", am4charts.PieChart);

/* Add data */
chart.data = [{
    "country": "Lithuania",
    "litres": 501.9
}, {
    "country": "Czechia",
    "litres": 301.9
}, {
    "country": "Ireland",
    "litres": 201.1
}, {
    "country": "Germany",
    "litres": 165.8
}, {
    "country": "Australia",
    "litres": 139.9
}, {
    "country": "Austria",
    "litres": 128.3
}, {
    "country": "UK",
    "litres": 99
}, {
    "country": "Belgium",
    "litres": 60
}, {
    "country": "The Netherlands",
    "litres": 50
}, {
    "country": "Hungary",
    "litres": 50
}, {
    "country": "Poland",
    "litres": 50
}, {
    "country": "Greece",
    "litres": 50
}, {
    "country": "Italy",
    "litres": 50
}, {
    "country": "France",
    "litres": 50
}, {
    "country": "Spain",
    "litres": 50
}];

/* Create series */
var series = chart.series.push(new am4charts.PieSeries());
series.dataFields.value = "litres";
series.dataFields.category = "country";

/* Disable labels */
series.labels.template.disabled = true;
series.ticks.template.disabled = true;

/* Create legend */
chart.legend = new am4charts.Legend();

/* Create a separate container to put legend in */
var legendContainer = am4core.create("legenddiv", am4core.Container);
legendContainer.width = am4core.percent(100);
legendContainer.height = am4core.percent(100);
chart.legend.parent = legendContainer;

chart.events.on("datavalidated", resizeLegend);
chart.events.on("maxsizechanged", resizeLegend);

chart.legend.events.on("datavalidated", resizeLegend);
chart.legend.events.on("maxsizechanged", resizeLegend);

function resizeLegend(ev) {
    document.getElementById("legenddiv").style.height = chart.legend.contentHeight + "px";
}

chart.exporting.menu = new am4core.ExportMenu();
chart.exporting.extraSprites.push({
    "sprite": legendContainer,
    "position": "bottom",
    "marginTop": 20
});