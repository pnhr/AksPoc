
@REM docker pull psazappcontainer.azurecr.io/psaksimg:latest

kubectl apply -f .\deployment.yml
kubectl apply -f .\service.yml
kubectl get deployments
kubectl get services

