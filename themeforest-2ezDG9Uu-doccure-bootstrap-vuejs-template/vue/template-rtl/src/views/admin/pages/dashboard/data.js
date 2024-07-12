const splineAreaChart = {
  
    slinearea: {
        chart: {
          id: "vuechart-example",
        },

		chart: {
			type: 'area',
			height: 350,
		  },
          dataLabels: {
            enabled: false
        },
		  xaxis: {
			type: 'category',
			categories: ['2013', '2014', '2015', '2016', '2017', '2018', '2019'],
		  },
		  colors: ['#1b5a90'],
		  stroke: {
			width: 2,
		  },
		  fill: {
			opacity: 0.5,
		  },
		  grid: {
			textSize: 10,
		  },
		  tooltip: {
			enabled: true,
			shared: false,
			x: {
			  show: true,
			},
			y: {
			  formatter: function (val) {
				return '$' + val;
			  },
			},
		  },
  },
	  series: [
		{
		  name: 'Revenue',
		  data: [
			{ x: '2013', y: 60 },
			{ x: '2014', y: 100 },
			{ x: '2015', y: 240 },
			{ x: '2016', y: 120 },
			{ x: '2017', y: 80 },
			{ x: '2018', y: 100 },
			{ x: '2019', y: 300 },
		  ],
		},
	  ],
};
const splineChart = {
    slineline: {
        chart: {
          id: "vuechart-example",
        },

		chart: {
		type: 'line',
		height: 350,
	  },
      xaxis: {
        type: 'category',
        categories: ['2015', '2016', '2017', '2018', '2019'],
      },
      colors: ['#1b5a90', '#ff9d00'],
      stroke: {
        width: 1,
        curve: "smooth"
      },
      grid: {
        textSize: 10,
      },
      tooltip: {
        enabled: true,
        shared: false,
        x: {
          show: true,
        },
        y: {
          formatter: function (val) {
            return val;
          },
        },
      },
      },
      series: [
        {
          name: 'Doctors',
          data: [
            { x: '2015', y: 100 },
            { x: '2016', y: 20 },
            { x: '2017', y: 90 },
            { x: '2018', y: 50 },
            { x: '2019', y: 120 },
          ],
        },
        {
          name: 'Patients',
          data: [
            { x: '2015', y: 30 },
            { x: '2016', y: 60 },
            { x: '2017', y: 120 },
            { x: '2018', y: 80 },
            { x: '2019', y: 150 },
          ],
        },
      ],
};
export {
    splineAreaChart,
    splineChart,
  };