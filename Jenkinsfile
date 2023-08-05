pipeline {
    agent any
    options {
        skipStagesAfterUnstable()
    }
    stages {
        stage('Build') {
            steps {
              echo 'Building'
            }
        }
        stage('Test') {
             steps {
               echo 'Testing'
             }
        }
        stage('Deploy to staging') {
             steps {
               echo 'Deploy to staging'
             }
        }
        stage('Deploy to prod') {
             steps {
                echo 'Deploy to prod'
             }
         }
    }
}
