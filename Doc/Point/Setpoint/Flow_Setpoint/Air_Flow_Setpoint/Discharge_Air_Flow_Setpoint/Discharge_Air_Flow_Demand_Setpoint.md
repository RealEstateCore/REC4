[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Flow_Setpoint](../../Flow_Setpoint.md) > [Air_Flow_Setpoint](../Air_Flow_Setpoint.md) > [Discharge_Air_Flow_Setpoint](Discharge_Air_Flow_Setpoint.md) > [Discharge_Air_Flow_Demand_Setpoint](.)
# Discharge_Air_Flow_Demand_Setpoint
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Flow_Demand_Setpoint;1
## Display name
- **en:** Discharge Air Flow Demand Setpoint
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint