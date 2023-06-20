
@REM docker pull psacrpoc.azurecr.io/psaksimg:latest

kubectl apply -f .\deployment.yml
kubectl apply -f .\service.yml
kubectl get deployments
kubectl get services

