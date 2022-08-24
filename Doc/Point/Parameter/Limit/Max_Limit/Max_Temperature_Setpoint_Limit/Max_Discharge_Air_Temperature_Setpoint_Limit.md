[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Max_Limit](../Max_Limit.md) > [Max_Temperature_Setpoint_Limit](Max_Temperature_Setpoint_Limit.md) > [Max_Discharge_Air_Temperature_Setpoint_Limit](.)
# Max_Discharge_Air_Temperature_Setpoint_Limit
**DTMI:** dtmi:org:brickschema:schema:Brick:Max_Discharge_Air_Temperature_Setpoint_Limit;1
## Display name
- **en:** Max Discharge Air Temperature Setpoint Limit
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