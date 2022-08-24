[Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [PID_Parameter](../../../PID_Parameter.md) > [Step_Parameter](../../Step_Parameter.md) > [Temperature_Step_Parameter](../Temperature_Step_Parameter.md) > [Air_Temperature_Step_Parameter](Air_Temperature_Step_Parameter.md) > [Supply_Air_Temperature_Step_Parameter](#)
# Supply_Air_Temperature_Step_Parameter

**Display name:** Supply Air Temperature Step Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Temperature_Step_Parameter;1

---
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
