pipeline {
    agent any
    stages {
        stage("compilar") {
            steps {
                sh "dotnet build"
            }
        }
        stage("Tests unitaris") {
            steps {
                sh "dotnet test"
            }
        }
    }
}