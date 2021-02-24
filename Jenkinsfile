pipeline {
    agent any
    stages {
        stage("compilar") {
            steps {
                sh "dotnet build"
            }
        }
        stage("Tests unitaris") {
            parallel {
                stage("Tests 1") {
                    steps {
                        sh "dotnet test CalculadoraTest/"
                    }
                }
                stage("Tests 2") {
                    steps {
                        sh "dotnet test CalculadoraTest2/"
                    }
                }
            }
        }
    }
}