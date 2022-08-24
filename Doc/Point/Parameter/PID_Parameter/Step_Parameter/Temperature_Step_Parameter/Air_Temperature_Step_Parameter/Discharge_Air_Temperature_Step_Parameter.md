[Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [PID_Parameter](../../../PID_Parameter.md) > [Step_Parameter](../../Step_Parameter.md) > [Temperature_Step_Parameter](../Temperature_Step_Parameter.md) > [Air_Temperature_Step_Parameter](Air_Temperature_Step_Parameter.md) > [Discharge_Air_Temperature_Step_Parameter](.)
# Discharge_Air_Temperature_Step_Parameter
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Step_Parameter;1
## Display name
- **en:** Discharge Air Temperature Step Parameter
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