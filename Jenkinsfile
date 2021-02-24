pipeline {
    agent any
    environment {
        NUMERO = "UdG-${BUILD_NUMBER}"
    }
    stages {
        stage("compilar") {
            steps {
                echo "$NUMERO"
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
        stage("deploy") {
            when {
                anyOf {
                    branch "main"
                }
            }
            steps {
                echo "Desplegar"
            }
        }
    }
}