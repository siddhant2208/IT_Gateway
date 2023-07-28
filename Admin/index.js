const ctx = document.getElementById('myPieChart').getContext('2d');
    let myPieChart;

    const dataMap = {
      option1: [40, 30, 30],
      option2: [10, 50, 40],
      option3: [20, 20, 60],
      option4: [25, 35, 40],
    };

    function updateChart() {
      const selectedOption = document.getElementById('colors').value;
      const data = dataMap[selectedOption];

      if (myPieChart) {
        myPieChart.destroy();
      }

      // Show the loading message
      setTimeout(() => {
        myPieChart = new Chart(ctx, {
          type: 'pie',
          data: {
            labels: ['Assigned', 'Unassigned', 'Repair'],
            datasets: [{
              data: data,
              backgroundColor: ['#D84063', '#EBAD31', '#41B0A9'],
              borderWidth: 1
            }]
          },
          options: {
            responsive: true,
            maintainAspectRatio: false,
            plugins: {
              legend: {
                  labels: {
                      font: {
                          size: 10
                      }
                  }
              }
          }

          }
        });

        // Hide the loading message and show the chart
        document.getElementById('chart-container').style.opacity = 1;
      }); // Simulating a 2-second delay for the loading effect 
    }

    window.addEventListener('load', updateChart);