pipeline {
    environment {
        registry = "mastex/web"
        DOCKER_PWD = credentials('docker-login-pwd')
    }
    agent {
        docker {
            image 'dockerforjobseekers/node-docker2'
            args '-p 3000:3000'
            args '-w /app'
            args '-v /var/run/docker.sock:/var/run/docker.sock'
        }
    }
    options {
        skipStagesAfterUnstable()
    }
    stages {
        stage('Build') {
            steps {
              echo('Building...')
              sh 'pwd'
              sh 'ls'
              dir('web') {
                sh 'ls'
                sh 'npm install'
              }
            }
        }
        stage('Test') {
             steps {
               echo('Testing...')
               sh 'pwd'
               sh 'ls'
               dir('web') {
                 sh 'ls'
                 sh 'cat package.json'
                 sh 'npm test'
               }
             }
        }
        stage('Build & Push Docker image') {
             steps {
               echo('Building & Pushing Docker Image...')
               sh 'docker image build -t $registry:$BUILD_NUMBER .'
               sh 'docker login -u mastex -p $DOCKER_PWD'
               sh 'docker image push $registry:$BUILD_NUMBER'
               sh 'docker image rm $registry:$BUILD_NUMBER'
             }
        }
    }
}
